using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CBS___DBMS
{
    public partial class Login : Form
    {
        SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter rs = new SqlDataAdapter();

        public static String userid;  

        public Login()
        {
            InitializeComponent();

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text != "" & txtpass.Text != "")
            {

                COn.Open();
                string SQL = "SELECT * FROM users WHERE username ='" + txtuser.Text + "' AND password='" + txtpass.Text + "'";

                SqlCommand cmd = new SqlCommand(SQL, COn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == false)
                {
                    MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtuser.Text = "";
                    txtpass.Text = "";
                    COn.Close();
                    txtuser.Focus();
                }
                else
                {
                    userid = txtuser.Text;

                    MessageBox.Show("Welcome to the System, sir " + userid, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    COn.Close();
                    this.Hide();


                    Main MainForm = new Main();
                    MainForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Enter username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtuser.Focus();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            string exit_app = System.Convert.ToString(MessageBox.Show("Sure to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (exit_app == Convert.ToString(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                txtuser.Focus();
            }
        }


    }
}