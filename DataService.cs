using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class DataService
    {
        public List<Service> Services = new List<Service>();

        public DataService()
        {
            Services.Add(new Service("Short service", 5, 0));
            Services.Add(new Service("Medium service", 10, 0));
            Services.Add(new Service("Big service", 25, 0));
        }
    }
}
