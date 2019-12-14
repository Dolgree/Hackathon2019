using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class DataOffice
    {
        public List<Office> Offices = new List<Office>();

        public DataOffice()
        {
            Random random = new Random();
            for(int i = 0; i < 6; i++)
                Offices.Add(new Office(i.ToString(), 10));
        }

    }
}
