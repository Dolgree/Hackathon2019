using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Way
    {
        public string Address;
        public uint Time;//время в пути в минутах
        public uint Distance;

        public Way(string address, uint time, uint distance)
        {
            Address = address;
            Time = time;
            Distance = distance;
        }

        public override string ToString()
        {
            return $"Way: {Address} Time: {Time} Distance: {Distance}";
        }
    }
}
