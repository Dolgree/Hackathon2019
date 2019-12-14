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
    public partial class ReserveForm : Form
    {
        public static List<ReserveData> ReservesData = new List<ReserveData>();
        public static List<Reserve> NewReserves = new List<Reserve>();
        private List<DataGridView> dataGridViews;

        static ReserveForm()
        {
            for (int i = 0; i < 6; i++)
                ReservesData.Add(new ReserveData());
        }

        public ReserveForm()
        {
            InitializeComponent();
            DataOffice dataOffice = new DataOffice();
            for (int i = 0; i < dataOffice.Offices.Count; i++)
                AddressComboBox.Items.Add(dataOffice.Offices[i].Address);
            DataService dataService = new DataService();
            for (int i = 0; i < dataService.Services.Count; i++)
                ServiceComboBox.Items.Add(dataService.Services[i].Name);
            AddressComboBox.SelectedIndex = 0;
            HoursComboBox.SelectedIndex = 0;
            MinutesComboBox.SelectedIndex = 0;
            ServiceComboBox.SelectedIndex = 0;
            var dateTime = DateTime.Now;
            dateTime = dateTime.AddDays(1);
            DateTimePicker.Value = dateTime;
            dataGridViews = new List<DataGridView>() { ReservedTimeGrid0, ReservedTimeGrid1, ReservedTimeGrid2, ReservedTimeGrid3, ReservedTimeGrid4, ReservedTimeGrid5 };
            for(int i = 0; i < 6; i++)
                GridPull(ReservesData[i].Reserves, dataGridViews[i]);
        }

        private void AddReserve_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime(DateTimePicker.Text);
            DateTime newDateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, Convert.ToInt32(HoursComboBox.Text), Convert.ToInt32(MinutesComboBox.Text), 0);
            Reserve reserve = new Reserve(AddressComboBox.Text, newDateTime, ServiceComboBox.Text);
            NewReserves.Clear();
            if (newDateTime.Day > DateTime.Now.Day)
            {
                if (ReservesData[AddressComboBox.SelectedIndex].AddReserve(reserve, AddressComboBox.SelectedIndex))
                {
                    NewReserves.Add(reserve);
                    ToolStripStatusLabel.Text = "Готово";
                    GridPull(ReservesData[AddressComboBox.SelectedIndex].Reserves, dataGridViews[AddressComboBox.SelectedIndex]);
                }
                else
                {
                    ToolStripStatusLabel.Text = "Время недоступно";
                }
            }
            else
                ToolStripStatusLabel.Text = "Запись на эти дни прекращена";
        }

        public void GridPull(List<Reserve> reserves, DataGridView reservedTimeGrid)
        {
            reserves = ReservesData[AddressComboBox.SelectedIndex].Reserves;
            DataOffice dataOffice = new DataOffice();
            reservedTimeGrid.Rows.Clear();
            for (int i = 0; i < reserves.Count; i++)
            {
                var serviceReserve = dataOffice.Offices[AddressComboBox.SelectedIndex].DataServices.Services.First(service => service.Name == reserves[i].Service);
                var endDateTime = reserves[i].WriteTime.AddMinutes(Convert.ToDouble(serviceReserve.Time));
                reservedTimeGrid.Rows.Add(reserves[i].WriteTime, endDateTime);
            }
        }
    }
}
