using Microsoft.VisualBasic;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yienfrontend
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string uri = "https://localhost:7159/api/Products\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Products>>(json);

        }

        public class Products
        {
            public Guid Id { get; set; }
            public string OrderID { get; set; }
            public string Name { get; set; }
            public long WeightInGrams { get; set; }

            public string Condition { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
            }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
    }

