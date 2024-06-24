using Microsoft.VisualBasic;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Net.Http;
using System.Web;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Serialization;

namespace yienfrontend
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        //Products
        public class Products
        {
            public Guid Id { get; set; }
            public string OrderID { get; set; }
            public string Name { get; set; }
            public string WeightInGrams { get; set; }

            public string Condition { get; set; }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string uri = "https://localhost:7159/api/Products";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Products product = new Products();
            product.OrderID = textBox1.Text;
            product.Name = textBox2.Text;
            product.WeightInGrams = textBox3.Text;
            product.Condition = textBox4.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(product);
            client.UploadString(uri, data);
            MessageBox.Show("Added Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClearTextBoxes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}