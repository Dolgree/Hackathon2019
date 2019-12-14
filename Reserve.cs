using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonMFClever
{
    public class Reserve
    {
        public string Address;
        public DateTime WriteTime;//время записи
        public string Service;

        public Reserve(string address, DateTime writeTime, string service)
        {
            Address = address;
            WriteTime = writeTime;
            Service = service;
        }

        public override string ToString()
        {
            return $"Reverse: {Address} {WriteTime} {Service}";
        }
    }
}
