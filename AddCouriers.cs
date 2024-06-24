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
using static yienfrontend.AddCouriers;

namespace yienfrontend
{
    public partial class AddCouriers : Form
    {
        public AddCouriers()
        {
            InitializeComponent();
        }

        public class Couriers
        {
            public Guid Id { get; set; }
            public string CourierName { get; set; }
            public string Address { get; set; }
            public string Continent { get; set; }
            public string PhoneNo { get; set; }
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

        private void AddCouriers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:7159/api/Couriers";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Couriers courier = new Couriers();
            courier.CourierName = textBox1.Text;
            courier.Address = textBox2.Text;
            courier.Continent = textBox3.Text;
            courier.PhoneNo = textBox4.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(courier);
            client.UploadString(uri, data);
            MessageBox.Show("Added Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
