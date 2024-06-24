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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:7159/api/Orders\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Orders>>(json);

        }

        public class Orders
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string ParcelName { get; set; }
            public long PhoneNo { get; set; }
            public string Status { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
