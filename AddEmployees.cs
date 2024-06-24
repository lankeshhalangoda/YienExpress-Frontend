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
using static yienfrontend.AddEmployees;

namespace yienfrontend
{
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        public class Employees
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Company { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:7159/api/Employees";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Employees employee = new Employees();
            employee.Name = textBox1.Text;
            employee.Company = textBox2.Text;
            employee.City = textBox3.Text;
            employee.Country = textBox4.Text;
            employee.PhoneNo = textBox5.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(employee);
            client.UploadString(uri, data);
            MessageBox.Show("Added Successfully");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
