namespace WindowsFormsApplication1
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.gblogin = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblabc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gblogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(81, 28);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(112, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(81, 64);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(112, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(9, 105);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(333, 291);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // gblogin
            // 
            this.gblogin.Controls.Add(this.btnclear);
            this.gblogin.Controls.Add(this.label1);
            this.gblogin.Controls.Add(this.txtemail);
            this.gblogin.Controls.Add(this.btnlogin);
            this.gblogin.Controls.Add(this.label2);
            this.gblogin.Controls.Add(this.txtpassword);
            this.gblogin.Location = new System.Drawing.Point(118, 138);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(209, 135);
            this.gblogin.TabIndex = 6;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "Login";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(128, 105);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblabc
            // 
            this.lblabc.AutoSize = true;
            this.lblabc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabc.ForeColor = System.Drawing.Color.Navy;
            this.lblabc.Location = new System.Drawing.Point(70, 94);
            this.lblabc.Name = "lblabc";
            this.lblabc.Size = new System.Drawing.Size(308, 19);
            this.lblabc.TabIndex = 7;
            this.lblabc.Text = "ABC LIBRARY MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.istockphoto_1221128440_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(188, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblabc);
            this.Controls.Add(this.gblogin);
            this.Controls.Add(this.btnexit);
            this.Name = "Login";
            this.Text = "Login";
            this.gblogin.ResumeLayout(false);
            this.gblogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox gblogin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblabc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

