using iResell.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iResell
{
    public partial class frmAdminDashboard : Form
    {
        public static string transactionType;

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedIn.Text = frmLogin.loggedIn;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
        }

        private void deealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions transaction = new frmTransactions();
            transaction.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void exploiterLoadCombosBtn_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
        }



        private void usersTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmUsers myForm = new frmUsers();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void categoryTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmCategories myForm = new frmCategories();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void productTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmProducts myForm = new frmProducts();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void dealerandcustomerTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmDeaCust myForm = new frmDeaCust();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void inventoryTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmInventory myForm = new frmInventory();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void transactionTab_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmTransactions myForm = new frmTransactions();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmUsers myForm = new frmUsers();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void TopPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            mainpanel.Controls.Clear();
            frmPurchaseAndSales myForm = new frmPurchaseAndSales();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void salesTab_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            mainpanel.Controls.Clear();
            frmPurchaseAndSales myForm = new frmPurchaseAndSales();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mainpanel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
