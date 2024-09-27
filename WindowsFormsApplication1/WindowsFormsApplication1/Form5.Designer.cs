namespace WindowsFormsApplication1
{
    partial class newstudent
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
            this.lblbid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.booksearch = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.searchbook = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblstu = new System.Windows.Forms.Label();
            this.booksearch.SuspendLayout();
            this.searchbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.Location = new System.Drawing.Point(32, 26);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(73, 13);
            this.lblbid.TabIndex = 0;
            this.lblbid.Text = "Type Book ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(49, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // booksearch
            // 
            this.booksearch.Controls.Add(this.btnsearch);
            this.booksearch.Controls.Add(this.txtid);
            this.booksearch.Controls.Add(this.lblbid);
            this.booksearch.Location = new System.Drawing.Point(60, 67);
            this.booksearch.Name = "booksearch";
            this.booksearch.Size = new System.Drawing.Size(185, 115);
            this.booksearch.TabIndex = 3;
            this.booksearch.TabStop = false;
            this.booksearch.Text = "Search Book";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(62, 77);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // searchbook
            // 
            this.searchbook.Controls.Add(this.lbl5);
            this.searchbook.Controls.Add(this.lbl4);
            this.searchbook.Controls.Add(this.lbl3);
            this.searchbook.Controls.Add(this.lbl2);
            this.searchbook.Controls.Add(this.lbl1);
            this.searchbook.Controls.Add(this.label5);
            this.searchbook.Controls.Add(this.label4);
            this.searchbook.Controls.Add(this.label3);
            this.searchbook.Controls.Add(this.label2);
            this.searchbook.Controls.Add(this.label1);
            this.searchbook.Location = new System.Drawing.Point(315, 60);
            this.searchbook.Name = "searchbook";
            this.searchbook.Size = new System.Drawing.Size(184, 160);
            this.searchbook.TabIndex = 4;
            this.searchbook.TabStop = false;
            this.searchbook.Text = "Book";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(119, 132);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 9;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(119, 110);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(119, 84);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 7;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(119, 59);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(119, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(475, 226);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Back to Login";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblstu
            // 
            this.lblstu.AutoSize = true;
            this.lblstu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstu.Location = new System.Drawing.Point(231, 23);
            this.lblstu.Name = "lblstu";
            this.lblstu.Size = new System.Drawing.Size(83, 19);
            this.lblstu.TabIndex = 6;
            this.lblstu.Text = "STUDENT";
            // 
            // newstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 261);
            this.Controls.Add(this.lblstu);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.searchbook);
            this.Controls.Add(this.booksearch);
            this.Name = "newstudent";
            this.Text = "Student";
            this.booksearch.ResumeLayout(false);
            this.booksearch.PerformLayout();
            this.searchbook.ResumeLayout(false);
            this.searchbook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox booksearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox searchbook;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblstu;
    }
}