using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CBS___DBMS
{
    public partial class GenerateCode : Form
    {
        SqlConnection cn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd = new SqlCommand();

        public GenerateCode()
        {
            InitializeComponent();
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
                cn.Open();
            int start = 0;
            string thecode;

            while (start < Int32.Parse(txtcode.Text))
            {
                start = start + 1;
                thecode = "VOTER-" + start + "-2014";

                cmd.CommandText = "INSERT INTO Codes (Vcode) VALUES ('" + thecode + "')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
            }

            cn.Close();
            MessageBox.Show("Code Generation Complete","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void GenerateCode_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }
    }
}