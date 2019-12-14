using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonMFClever
{
    public partial class Form1 : Form
    {
        private Client Client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var countHuman = random.Next(10, 101);
            DataOffice dataOffice = new DataOffice();
            DataService dataService = new DataService();
            ClearQueue(dataOffice);
            GenerateQueue(random, countHuman, dataOffice, dataService);
            Log(dataOffice);
        }

        private void Log(DataOffice dataOffice)
        {
            Data.Text = $"Current user address: {Client.CurrentUserAddress}\n";
            var ways = Client.SetWays();
            for (int i = 0; i < ways.Count; i++)
            {
                Data.Text += ways[i].ToString();
                dataOffice.Offices[i].CalculateDelay();
                Data.Text += dataOffice.Offices[i] + "\n";
            }
        }

        private void GenerateQueue(Random random, int countHuman, DataOffice dataOffice, DataService dataService)
        {
            var dateTime = DateTime.Now;
            ReserveForm.ReservesData.Clear();
            for (int i = 0; i < 6; i++)
                ReserveForm.ReservesData.Add(new ReserveData());
            List<DateTime> writeTimes = new List<DateTime>();
            for(int i = 0; i < 6; i++)
                writeTimes.Add(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day + 1, 8, dateTime.Minute, 0));
            for (uint i = 0; i < countHuman; i++)
            {
                var officeIndex = random.Next(0, 6);
                var office = dataOffice.Offices[officeIndex];
                var serviceIndex = random.Next(0, 3);
                var service = dataService.Services[serviceIndex];
                office.DataServices.Services[serviceIndex].CountHuman++;
                writeTimes[officeIndex] = writeTimes[officeIndex].AddHours(1);
                if (writeTimes[officeIndex].Hour >= 21)
                    writeTimes[officeIndex] = writeTimes[officeIndex].AddHours(21 - writeTimes[officeIndex].Hour + 11);
                ReserveForm.ReservesData[officeIndex].Reserves.Add(new Reserve(office.Address, writeTimes[officeIndex], service.Name));
                var id = random.Next(5);
                Client = new Client(id);
            }
        }

        private void ClearQueue(DataOffice dataOffice)
        {
            for (int i = 0; i < dataOffice.Offices.Count; i++)
            {
                for (int t = 0; t < dataOffice.Offices[i].DataServices.Services.Count; t++)
                {
                    dataOffice.Offices[i].DataServices.Services[t].CountHuman = 0;
                }
            }
        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm();
            reserveForm.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshReserve();
        }

        private void RefreshReserve()
        {
            DataOffice dataOffice = new DataOffice();
            for(int i = 0; i < dataOffice.Offices.Count; i++)
            {
                for (int t = 0; t < dataOffice.Offices[i].DataServices.Services.Count; t++)
                {
                    for (int j = 0; j < ReserveForm.ReservesData[i].Reserves.Count; j++)
                    {
                        if (dataOffice.Offices[i].DataServices.Services[t].Name == ReserveForm.ReservesData[i].Reserves[j].Service)
                            dataOffice.Offices[i].DataServices.Services[t].CountHuman++;
                    }
                }
            }
            Log(dataOffice);
        }
    }
}
