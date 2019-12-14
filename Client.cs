using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Client
    {
        private List<Way> Ways = new List<Way>();
        private List<string> userAddress = new List<string>() { "Кирова, 44", "Олега Кошевого, 3", "Аякс посёлок, 10, стю 1.9", "Пацаева, 5", "Баляева, 27" };
        public string CurrentUserAddress;

        public Client(int id)
        {
            var officeAddress = new List<string>() { "Давыдова, 9", "Партизанский проспект, 28а", "Невельского, 13", "Верхнепортовая, 76а", "Борисенко, 102", "Проспект 100-лет, 44" };
            var distance = new List<List<int>>() { new List<int>() { 3, 11, 22, 20, 8 }, new List<int>() { 7, 7, 18, 16, 4 }, new List<int>() { 12, 7, 15, 7, 6 }, new List<int>() { 12, 10, 22, 19, 9 }, new List<int>() { 27, 10, 11, 2, 16 }, new List<int>() { 4, 8, 20, 17, 6 } };
            CurrentUserAddress = userAddress[id];
            var map = new Map(userAddress[id], officeAddress);
            Ways = map.CalculateWay(distance, id);
        }

        public List<Way> SetWays()
        {
            return Ways.OrderBy(way => way.Time).ToList();
        }
    }
}
