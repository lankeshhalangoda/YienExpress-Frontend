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
using static yienfrontend.AddProducts;

namespace yienfrontend
{
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        public class Customers
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Gender { get; set; }
            public string Age { get; set; }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:7159/api/Customers";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Customers customer = new Customers();
            customer.Name = textBox1.Text;
            customer.Address = textBox2.Text;
            customer.City = textBox3.Text;
            customer.Gender = textBox4.Text;
            customer.Age = textBox5.Text;
            customer.PhoneNo = textBox6.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(customer);
            client.UploadString(uri, data);
            MessageBox.Show("Added Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
