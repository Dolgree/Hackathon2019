using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class ReserveData
    {
        public List<Reserve> Reserves { get; private set; } = new List<Reserve>();

        public ReserveData()
        {

        }

        public ReserveData(List<Reserve> reserves)
        {
            Reserves = reserves;
            Reserves.OrderBy(reserve => reserve.WriteTime);
        }

        public bool AddReserve(Reserve reserve, int officeIndex)
        {
            var isFree = true;
            DataOffice dataOffice = new DataOffice();
            for (int i = 0; i < Reserves.Count; i++)
            {                
                var serviceReserve = dataOffice.Offices[officeIndex].DataServices.Services.First(service => service.Name == Reserves[i].Service);
                var endDateTime = Reserves[i].WriteTime.AddMinutes(Convert.ToDouble(serviceReserve.Time));
                var reserveEndDateTime = reserve.WriteTime.AddMinutes(Convert.ToDouble(serviceReserve.Time));
                if ((Reserves[i].WriteTime <= reserve.WriteTime && reserve.WriteTime < endDateTime || Reserves[i].WriteTime <= reserveEndDateTime && reserveEndDateTime < endDateTime) && Reserves[i].Address == reserve.Address)
                {
                    isFree = false;
                    continue;
                }
                else
                    continue;
            }
            if (isFree)
            {
                Reserves.Add(reserve);
                Reserves = Reserves.OrderBy(reserved => reserved.WriteTime).ToList<Reserve>();
            }
            ShowReserve();
            return isFree;
        }

        public void ShowReserve()
        {
            DataService dataService = new DataService();
            for (int i = 0; i < Reserves.Count; i++)
            {
                var serviceReserve = dataService.Services.First(service => service.Name == Reserves[i].Service);
                var endDateTime = Reserves[i].WriteTime.AddMinutes(Convert.ToDouble(serviceReserve.Time));
            }
        }
    }
}
