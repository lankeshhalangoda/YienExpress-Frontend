using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yienfrontend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrders sibling = new AddOrders();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomers sibling = new AddCustomers();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProducts sibling = new AddProducts();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddEmployees sibling = new AddEmployees();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddCouriers sibling = new AddCouriers();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrders sibling = new ViewOrders();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustomers sibling = new ViewCustomers();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewProducts sibling = new ViewProducts();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewEmployees sibling = new ViewEmployees();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ViewCouriers sibling = new ViewCouriers();
            sibling.MdiParent = this.MdiParent;
            sibling.Show();
        }
    }
}
