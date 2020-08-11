namespace CBS___DBMS
{
    partial class RegParty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegParty));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPacro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(228, 133);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 28);
            this.btn_cancel.TabIndex = 61;
            this.btn_cancel.Text = "  &Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(139, 133);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 28);
            this.btn_save.TabIndex = 60;
            this.btn_save.Text = "  &Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(317, 133);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 28);
            this.btn_exit.TabIndex = 59;
            this.btn_exit.Text = "&EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = global::CBS___DBMS.Properties.Resources.add;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(50, 133);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 28);
            this.btn_new.TabIndex = 58;
            this.btn_new.Text = "   &New";
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Party List No:";
            // 
            // txtpid
            // 
            this.txtpid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpid.Enabled = false;
            this.txtpid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(141, 12);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(75, 26);
            this.txtpid.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Party List Name:";
            // 
            // txtPname
            // 
            this.txtPname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPname.Enabled = false;
            this.txtPname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.Location = new System.Drawing.Point(141, 44);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(290, 26);
            this.txtPname.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Acronym:";
            // 
            // txtPacro
            // 
            this.txtPacro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacro.Enabled = false;
            this.txtPacro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacro.Location = new System.Drawing.Point(140, 77);
            this.txtPacro.Name = "txtPacro";
            this.txtPacro.Size = new System.Drawing.Size(125, 26);
            this.txtPacro.TabIndex = 65;
            // 
            // RegParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPacro);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPacro;
    }
}