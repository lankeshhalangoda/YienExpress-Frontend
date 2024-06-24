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
using static yienfrontend.AddOrders;

namespace yienfrontend
{
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        public class Orders
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string ParcelName { get; set; }
            public string PhoneNo { get; set; }
            public string Status { get; set; }

        }
        //Clear Text Boxes
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:7159/api/Orders";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Orders order = new Orders();
            order.Name = textBox1.Text;
            order.Address = textBox2.Text;
            order.ParcelName = textBox3.Text;
            order.PhoneNo = textBox4.Text;
            order.Status = textBox5.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(order);
            client.UploadString(uri, data);
            MessageBox.Show("Added Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
