using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;


namespace CBS___DBMS
{
    public partial class Candidate : Form
    {
        SqlConnection cn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        string str;
        int COUNT;
        
        public Candidate()
        {
            InitializeComponent();

        }

        MemoryStream MS;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Candidate_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        //FUNCTION TO GENERATE NEW CANDIDATE ID

        private void GenId()
        {
            str = "SELECT COUNT (*) FROM candidates";
            cmd = new SqlCommand(str, cn);

            cn.Open();
            COUNT = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

            txtid.Text = "DCCP-CBS-"+ DateAndTime.Now.Year +"-00" + COUNT.ToString();
            txtid.Enabled = false;

            cn.Close();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            
         //CHECK IF TEXTBOXES ARE EMPTY OR NOT

            if (String.IsNullOrEmpty(txtfname.Text.Trim()))
            {
                MessageBox.Show("First name required.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtlname.Text.Trim()))
            {
                MessageBox.Show("Last name required.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtfname.Text.Trim()))
            {
                MessageBox.Show("First name required.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cmbCourse.Text.Trim()))
            {
                MessageBox.Show("Select Course.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCourse.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cmb_yl.Text.Trim()))
            {
                MessageBox.Show("Select Year level.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_yl.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cmb_post.Text.Trim()))
            {
                MessageBox.Show("Select Position.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_post.Focus();
                return;
            }

            if (pic1.Image == pic1.InitialImage)
            {
                string SkipUpload = System.Convert.ToString(MessageBox.Show("Are you sure to not upload image?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (SkipUpload == Convert.ToString(DialogResult.Yes))
                    {
                        btn_save.Focus();    
                        return;    
                    }
                else
                    {
                        openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                        DialogResult res = openFileDialog1.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            pic1.Image = Image.FromFile(openFileDialog1.FileName);
                        }
                    }
            }

            //INSERT NEW RECORD TO DATABASE

            GenId();
            cn.Open();

            cmd.CommandText = "INSERT INTO candidates (CID, cName, cCourse, cYL, cImg, cPosition, cParty) VALUES ('"+ txtid.Text +"', '" + txtfname.Text + " " + txtmname.Text + " " + txtlname.Text + "', '" + cmbCourse.Text + "', '" + cmb_yl.Text + "', @photo, '"+ cmb_post.Text +"', '"+ cmb_party.Text +"')";
            conv_photo();
            cmd.ExecuteNonQuery();
            cmd.Clone();

            MessageBox.Show("Record successully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cn.Close();
            this.Close();

    }

        private void btn_new_Click(object sender, EventArgs e)
        {

           // GenId();

            txtfname.Enabled = true;
            txtmname.Enabled = true;
            txtlname.Enabled = true;
            cmbCourse.Enabled = true;
            cmb_yl.Enabled = true;
            cmb_party.Enabled = true;
            cmb_post.Enabled = true;
            btn_ul.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;

            txtfname.Focus();
        }

        
        private void btn_ul_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        void conv_photo()
        {
            //converting photo to binary data
            if (pic1.Image != null)
            {
                //using MemoryStream:
                MS = new MemoryStream();
                pic1.Image.Save(MS, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[MS.Length];
                MS.Position = 0;
                MS.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtfname.Enabled = false;
            txtmname.Enabled = false;
            txtlname.Enabled = false;
            cmbCourse.Enabled = false;
            cmb_yl.Enabled = false;
            cmb_party.Enabled = false;
            cmb_post.Enabled = false;
            btn_ul.Enabled = false;
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }


        private void cmbCourse_Leave(object sender, EventArgs e)
        {
            if (cmbCourse.Text == "BSIT" || cmbCourse.Text == "BSCS" || cmbCourse.Text == "BSCRIM" || cmbCourse.Text == "BSHRM" || cmbCourse.Text == "BSOA" || cmbCourse.Text == "BSOA")
            {
                cmb_yl.Items.Clear();
                
                cmb_yl.Items.Add("1");
                cmb_yl.Items.Add("2");
                cmb_yl.Items.Add("3");
                cmb_yl.Items.Add("4");
            }

            if (cmbCourse.Text == "CHS NCII" || cmbCourse.Text == "PROG NCIV" || cmbCourse.Text == "BKK NCIII")
            {
                cmb_yl.Items.Clear();
                cmb_yl.Items.Add("1");
                cmb_yl.Items.Add("2");
            }

            if (cmbCourse.Text == "HCS")
            {
                cmb_yl.Items.Clear();
                cmb_yl.Items.Add("1");
            }

            if (cmbCourse.Text == "CG")
            {
                cmb_yl.Items.Clear();
                cmb_yl.Items.Add("7 MONTHS");
            }

        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !Char.IsLetter( e.KeyChar ) && (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space);
                base.OnKeyPress(e);
        }

        private void txtlname_Enter(object sender, EventArgs e)
        {
            if (txtmname.Text == "")
            {
                txtmname.Text = "N/A";
            }
            else
            {

            }
        }


    }
}