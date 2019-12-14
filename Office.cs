using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Office
    {
        public string Address;
        public uint Windowed;//количество окон
        public uint CurrentDelay = 0;//время ожидания
        public DataService DataServices = new DataService();

        public Office(string address, uint windowed)
        {
            Address = address;
            Windowed = windowed;
        }

        public void CalculateDelay()
        {
            for(int i = 0; i < DataServices.Services.Count; i++)
            {
                CurrentDelay += DataServices.Services[i].Time * DataServices.Services[i].CountHuman;
            }
            CurrentDelay /=  Windowed;
        }

        public override string ToString()
        {
            return $" Current delay: {CurrentDelay}\n";
        }
    }
}
