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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:7159/api/Employees\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employees>>(json);

        }

        public class Employees
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Company { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public long PhoneNo { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
