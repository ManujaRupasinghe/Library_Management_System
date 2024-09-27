namespace WindowsFormsApplication1
{
    partial class lecture
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
            this.seachbook = new System.Windows.Forms.GroupBox();
            this.btnbsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.seachstudent = new System.Windows.Forms.GroupBox();
            this.btnssearch = new System.Windows.Forms.Button();
            this.txtseach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.GroupBox();
            this.lblliblogo = new System.Windows.Forms.Label();
            this.seachbook.SuspendLayout();
            this.seachstudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.student.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search ID";
            // 
            // seachbook
            // 
            this.seachbook.Controls.Add(this.btnbsearch);
            this.seachbook.Controls.Add(this.txtsearch);
            this.seachbook.Controls.Add(this.label1);
            this.seachbook.Location = new System.Drawing.Point(27, 66);
            this.seachbook.Name = "seachbook";
            this.seachbook.Size = new System.Drawing.Size(171, 100);
            this.seachbook.TabIndex = 2;
            this.seachbook.TabStop = false;
            this.seachbook.Text = "Search Book";
            // 
            // btnbsearch
            // 
            this.btnbsearch.Location = new System.Drawing.Point(48, 68);
            this.btnbsearch.Name = "btnbsearch";
            this.btnbsearch.Size = new System.Drawing.Size(75, 23);
            this.btnbsearch.TabIndex = 2;
            this.btnbsearch.Text = "Search";
            this.btnbsearch.UseVisualStyleBackColor = true;
            this.btnbsearch.Click += new System.EventHandler(this.btnbsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(48, 42);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 1;
            // 
            // seachstudent
            // 
            this.seachstudent.Controls.Add(this.btnssearch);
            this.seachstudent.Controls.Add(this.txtseach);
            this.seachstudent.Controls.Add(this.label2);
            this.seachstudent.Location = new System.Drawing.Point(27, 176);
            this.seachstudent.Name = "seachstudent";
            this.seachstudent.Size = new System.Drawing.Size(171, 106);
            this.seachstudent.TabIndex = 3;
            this.seachstudent.TabStop = false;
            this.seachstudent.Text = "Search Student";
            // 
            // btnssearch
            // 
            this.btnssearch.Location = new System.Drawing.Point(48, 71);
            this.btnssearch.Name = "btnssearch";
            this.btnssearch.Size = new System.Drawing.Size(75, 23);
            this.btnssearch.TabIndex = 3;
            this.btnssearch.Text = "Search";
            this.btnssearch.UseVisualStyleBackColor = true;
            this.btnssearch.Click += new System.EventHandler(this.btnssearch_Click);
            // 
            // txtseach
            // 
            this.txtseach.Location = new System.Drawing.Point(35, 45);
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(100, 20);
            this.txtseach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pages";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Author";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(109, 7);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 9;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(109, 32);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(109, 60);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 11;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(109, 87);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 12;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(109, 115);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Gender";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Year";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(82, 16);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 13);
            this.lbl6.TabIndex = 21;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(82, 41);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(0, 13);
            this.lbl7.TabIndex = 22;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(82, 69);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(0, 13);
            this.lbl8.TabIndex = 23;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(82, 96);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(0, 13);
            this.lbl9.TabIndex = 24;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(82, 153);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(0, 13);
            this.lbl11.TabIndex = 26;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(85, 124);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 27;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(137, 124);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 28;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(238, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 137);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(605, 291);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 23);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "Back to Login";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // student
            // 
            this.student.Controls.Add(this.female);
            this.student.Controls.Add(this.male);
            this.student.Controls.Add(this.lbl11);
            this.student.Controls.Add(this.lbl9);
            this.student.Controls.Add(this.lbl8);
            this.student.Controls.Add(this.lbl7);
            this.student.Controls.Add(this.lbl6);
            this.student.Controls.Add(this.label19);
            this.student.Controls.Add(this.label18);
            this.student.Controls.Add(this.label17);
            this.student.Controls.Add(this.label16);
            this.student.Controls.Add(this.label15);
            this.student.Controls.Add(this.label14);
            this.student.Controls.Add(this.label13);
            this.student.Location = new System.Drawing.Point(468, 73);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(204, 184);
            this.student.TabIndex = 31;
            this.student.TabStop = false;
            this.student.Text = "Student";
            // 
            // lblliblogo
            // 
            this.lblliblogo.AutoSize = true;
            this.lblliblogo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliblogo.Location = new System.Drawing.Point(286, 21);
            this.lblliblogo.Name = "lblliblogo";
            this.lblliblogo.Size = new System.Drawing.Size(95, 19);
            this.lblliblogo.TabIndex = 32;
            this.lblliblogo.Text = "LECTURER";
            // 
            // lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 326);
            this.Controls.Add(this.lblliblogo);
            this.Controls.Add(this.student);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seachstudent);
            this.Controls.Add(this.seachbook);
            this.Name = "lecture";
            this.Text = "Lecture";
            this.seachbook.ResumeLayout(false);
            this.seachbook.PerformLayout();
            this.seachstudent.ResumeLayout(false);
            this.seachstudent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.student.ResumeLayout(false);
            this.student.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox seachbook;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox seachstudent;
        private System.Windows.Forms.TextBox txtseach;
        private System.Windows.Forms.Button btnbsearch;
        private System.Windows.Forms.Button btnssearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox student;
        private System.Windows.Forms.Label lblliblogo;
    }
}