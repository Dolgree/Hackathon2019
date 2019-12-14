using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Map
    {
        public string UserAddress;
        public List<string> OfficesAddress = new List<string>();

        public Map(string userAddress, List<string> officesAddress)
        {
            UserAddress = userAddress;
            OfficesAddress = officesAddress;
        }
        // рассчёт 
        public List<Way> CalculateWay()
        {
            //TODO API Map
            Random random = new Random();
            List<Way> ways = new List<Way>();
            for (int i = 0; i < OfficesAddress.Count; i++)
                ways.Add(new Way(OfficesAddress[i], Convert.ToUInt32(random.Next(5, 15)), Convert.ToUInt32(random.Next(5, 30))));
            return ways;
        }

        public List<Way> CalculateWay(List<List<int>> distance, int id)
        {
            //TODO API Map
            Random random = new Random();
            List<Way> ways = new List<Way>();
            for (int i = 0; i < OfficesAddress.Count; i++)
                ways.Add(new Way(OfficesAddress[i], (uint)(distance[i][id] * random.Next(1, 4)), (uint)distance[i][id]));
            return ways;
        }
    }
}
