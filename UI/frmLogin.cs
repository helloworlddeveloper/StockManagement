using iResell.BLL;
using iResell.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Properties;

namespace iResell.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;



        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();
            Settings.Default["dusername"] = txtUsername.Text;
            Settings.Default["dpassword"] = txtPassword.Text;
            Settings.Default.Save();
            //Checking the login credentials
            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {

                //Login Successfull
                MessageBox.Show("Login Successful.");

                loggedIn = l.username;
                //Need to open Respective Forms based on User Type
                switch (l.user_type)
                {

                    case "Admin":
                        {
                            //Display Admin Dashboard
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //Display User Dashboard
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Display an error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
                this.Hide();

            }
            else
            {
                //login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default["dusername"] != "" || Settings.Default["dpassword"] != "")
            {
                txtUsername.Text = Settings.Default["dusername"].ToString();
                txtPassword.Text = Settings.Default["dpassword"].ToString();
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ester Egg Found!!!");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
