namespace CBS___DBMS
{
    partial class Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Authentication Code :";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(25, 33);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.Size = new System.Drawing.Size(200, 30);
            this.txtcode.TabIndex = 0;
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_auth
            // 
            this.btn_auth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auth.ForeColor = System.Drawing.Color.Black;
            this.btn_auth.Image = ((System.Drawing.Image)(resources.GetObject("btn_auth.Image")));
            this.btn_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_auth.Location = new System.Drawing.Point(232, 33);
            this.btn_auth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(97, 30);
            this.btn_auth.TabIndex = 1;
            this.btn_auth.Text = "    &Re-Zero";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // Tools
            // 
            this.AcceptButton = this.btn_auth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(346, 85);
            this.Controls.Add(this.btn_auth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Tools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Button btn_auth;

    }
}