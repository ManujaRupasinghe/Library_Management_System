namespace WindowsFormsApplication1
{
    partial class student
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttp = new System.Windows.Forms.TextBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.searchbook = new System.Windows.Forms.GroupBox();
            this.btnsdelete = new System.Windows.Forms.Button();
            this.btnsupdate = new System.Windows.Forms.Button();
            this.btnssubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.female1 = new System.Windows.Forms.RadioButton();
            this.male1 = new System.Windows.Forms.RadioButton();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.searchbooks = new System.Windows.Forms.GroupBox();
            this.btnsbooks = new System.Windows.Forms.Button();
            this.txtsbooks = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblstudentlogo = new System.Windows.Forms.Label();
            this.searchbook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.searchbooks.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(29, 58);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(18, 32);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Acedmic Year";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 62);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(100, 122);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 11;
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(100, 156);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(100, 20);
            this.txttp.TabIndex = 12;
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(100, 218);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(100, 20);
            this.txtgrade.TabIndex = 13;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(100, 190);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 14;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(154, 192);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 15;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // searchbook
            // 
            this.searchbook.Controls.Add(this.btnsdelete);
            this.searchbook.Controls.Add(this.label1);
            this.searchbook.Controls.Add(this.txtsearch);
            this.searchbook.Controls.Add(this.btnsupdate);
            this.searchbook.Controls.Add(this.btnsearch);
            this.searchbook.Location = new System.Drawing.Point(358, 112);
            this.searchbook.Name = "searchbook";
            this.searchbook.Size = new System.Drawing.Size(127, 149);
            this.searchbook.TabIndex = 16;
            this.searchbook.TabStop = false;
            this.searchbook.Text = "Search Student";
            // 
            // btnsdelete
            // 
            this.btnsdelete.Location = new System.Drawing.Point(29, 87);
            this.btnsdelete.Name = "btnsdelete";
            this.btnsdelete.Size = new System.Drawing.Size(75, 23);
            this.btnsdelete.TabIndex = 3;
            this.btnsdelete.Text = "Delete";
            this.btnsdelete.UseVisualStyleBackColor = true;
            this.btnsdelete.Click += new System.EventHandler(this.btnsdelete_Click);
            // 
            // btnsupdate
            // 
            this.btnsupdate.Location = new System.Drawing.Point(29, 116);
            this.btnsupdate.Name = "btnsupdate";
            this.btnsupdate.Size = new System.Drawing.Size(75, 23);
            this.btnsupdate.TabIndex = 18;
            this.btnsupdate.Text = "Update";
            this.btnsupdate.UseVisualStyleBackColor = true;
            this.btnsupdate.Click += new System.EventHandler(this.btnsupdate_Click);
            // 
            // btnssubmit
            // 
            this.btnssubmit.Location = new System.Drawing.Point(35, 261);
            this.btnssubmit.Name = "btnssubmit";
            this.btnssubmit.Size = new System.Drawing.Size(75, 23);
            this.btnssubmit.TabIndex = 17;
            this.btnssubmit.Text = "Submit";
            this.btnssubmit.UseVisualStyleBackColor = true;
            this.btnssubmit.Click += new System.EventHandler(this.btnssubmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Year";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.female1);
            this.groupBox1.Controls.Add(this.male1);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(507, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 160);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // female1
            // 
            this.female1.AutoSize = true;
            this.female1.Location = new System.Drawing.Point(121, 109);
            this.female1.Name = "female1";
            this.female1.Size = new System.Drawing.Size(59, 17);
            this.female1.TabIndex = 26;
            this.female1.TabStop = true;
            this.female1.Text = "Female";
            this.female1.UseVisualStyleBackColor = true;
            // 
            // male1
            // 
            this.male1.AutoSize = true;
            this.male1.Location = new System.Drawing.Point(67, 108);
            this.male1.Name = "male1";
            this.male1.Size = new System.Drawing.Size(48, 17);
            this.male1.TabIndex = 30;
            this.male1.TabStop = true;
            this.male1.Text = "Male";
            this.male1.UseVisualStyleBackColor = true;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(64, 132);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 29;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(64, 86);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 28;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(64, 64);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 27;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 26;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 25;
            // 
            // searchbooks
            // 
            this.searchbooks.Controls.Add(this.btnsbooks);
            this.searchbooks.Controls.Add(this.txtsbooks);
            this.searchbooks.Controls.Add(this.label14);
            this.searchbooks.Location = new System.Drawing.Point(530, 6);
            this.searchbooks.Name = "searchbooks";
            this.searchbooks.Size = new System.Drawing.Size(127, 100);
            this.searchbooks.TabIndex = 26;
            this.searchbooks.TabStop = false;
            this.searchbooks.Text = "Search Books";
            this.searchbooks.Visible = false;
            // 
            // btnsbooks
            // 
            this.btnsbooks.Location = new System.Drawing.Point(43, 69);
            this.btnsbooks.Name = "btnsbooks";
            this.btnsbooks.Size = new System.Drawing.Size(59, 21);
            this.btnsbooks.TabIndex = 2;
            this.btnsbooks.Text = "Search";
            this.btnsbooks.UseVisualStyleBackColor = true;
            this.btnsbooks.Click += new System.EventHandler(this.btnsbooks_Click);
            // 
            // txtsbooks
            // 
            this.txtsbooks.Location = new System.Drawing.Point(18, 43);
            this.txtsbooks.Name = "txtsbooks";
            this.txtsbooks.Size = new System.Drawing.Size(100, 20);
            this.txtsbooks.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Type Books";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl10);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lbl9);
            this.groupBox2.Controls.Add(this.lbl8);
            this.groupBox2.Controls.Add(this.lbl7);
            this.groupBox2.Controls.Add(this.lbl6);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(224, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 123);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book";
            this.groupBox2.Visible = false;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(63, 107);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(41, 13);
            this.lbl10.TabIndex = 9;
            this.lbl10.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 107);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Author";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(63, 84);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(41, 13);
            this.lbl9.TabIndex = 7;
            this.lbl9.Text = "label22";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(61, 65);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(41, 13);
            this.lbl8.TabIndex = 6;
            this.lbl8.Text = "label21";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(63, 42);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(41, 13);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "label20";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(63, 16);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(41, 13);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Pages";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Category";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(138, 261);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(601, 308);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(86, 23);
            this.btnexit.TabIndex = 29;
            this.btnexit.Text = "Back to Login";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblstudentlogo
            // 
            this.lblstudentlogo.AutoSize = true;
            this.lblstudentlogo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentlogo.Location = new System.Drawing.Point(250, 9);
            this.lblstudentlogo.Name = "lblstudentlogo";
            this.lblstudentlogo.Size = new System.Drawing.Size(207, 19);
            this.lblstudentlogo.TabIndex = 31;
            this.lblstudentlogo.Text = "STUDENT MANAGEMENT";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 354);
            this.Controls.Add(this.lblstudentlogo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchbooks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnssubmit);
            this.Controls.Add(this.searchbook);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "student";
            this.Text = "Librarian";
            this.Load += new System.EventHandler(this.student_Load);
            this.searchbook.ResumeLayout(false);
            this.searchbook.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchbooks.ResumeLayout(false);
            this.searchbooks.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox searchbook;
        private System.Windows.Forms.Button btnsdelete;
        private System.Windows.Forms.Button btnssubmit;
        private System.Windows.Forms.Button btnsupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton male1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton female1;
        private System.Windows.Forms.GroupBox searchbooks;
        private System.Windows.Forms.Button btnsbooks;
        private System.Windows.Forms.TextBox txtsbooks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblstudentlogo;
    }
}