using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yienfrontend
{
    public partial class ViewCouriers : Form
    {
        public ViewCouriers()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:7159/api/Couriers\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvCouriers.DataSource = null;
            dgvCouriers.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Couriers>>(json);

        }

        public class Couriers
        {
            public Guid Id { get; set; }
            public string CourierName { get; set; }
            public string Address { get; set; }
            public string Continent { get; set; }
            public long PhoneNo { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
