using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Service
    {
        public string Name;
        public uint Time;//время оказания услуги в минутах
        public uint CountHuman;//количкство людей в очереди на эту услугу

        public Service(string name, uint time, uint countHuman)
        {
            Name = name;
            Time = time;
            CountHuman = countHuman;
        }

        public override string ToString()
        {
            return $"Service: {Name} {Time} {CountHuman}";
        }
    }

    
}
