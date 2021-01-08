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
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        //Set a public static method to specify whether the form is purchase or sales
        public static string transactionType;

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }



        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

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

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            frmDeaCust myForm = new frmDeaCust();
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

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
