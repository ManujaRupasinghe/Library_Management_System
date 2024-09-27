namespace WindowsFormsApplication1
{
    partial class Librairan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.txtpages = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.searchbook = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txttypeid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblliblogin = new System.Windows.Forms.Label();
            this.searchbook.SuspendLayout();
            this.book.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 107);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(119, 136);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(100, 20);
            this.txtcategory.TabIndex = 7;
            // 
            // txtpages
            // 
            this.txtpages.Location = new System.Drawing.Point(119, 164);
            this.txtpages.Name = "txtpages";
            this.txtpages.Size = new System.Drawing.Size(100, 20);
            this.txtpages.TabIndex = 8;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(119, 197);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(100, 20);
            this.txtauthor.TabIndex = 9;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(38, 149);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(48, 241);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 11;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // searchbook
            // 
            this.searchbook.Controls.Add(this.btnsearch);
            this.searchbook.Controls.Add(this.btndelete);
            this.searchbook.Controls.Add(this.txttypeid);
            this.searchbook.Controls.Add(this.btnupdate);
            this.searchbook.Controls.Add(this.label6);
            this.searchbook.Location = new System.Drawing.Point(297, 75);
            this.searchbook.Name = "searchbook";
            this.searchbook.Size = new System.Drawing.Size(149, 176);
            this.searchbook.TabIndex = 12;
            this.searchbook.TabStop = false;
            this.searchbook.Text = "Search Book";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(38, 89);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(38, 120);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txttypeid
            // 
            this.txttypeid.Location = new System.Drawing.Point(18, 57);
            this.txttypeid.Name = "txttypeid";
            this.txttypeid.Size = new System.Drawing.Size(100, 20);
            this.txttypeid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "lD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pages";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Author";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(82, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 18;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(82, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 19;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(82, 70);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 20;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(82, 93);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 21;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(82, 120);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 22;
            // 
            // book
            // 
            this.book.Controls.Add(this.label7);
            this.book.Controls.Add(this.lbl5);
            this.book.Controls.Add(this.label8);
            this.book.Controls.Add(this.lbl4);
            this.book.Controls.Add(this.label9);
            this.book.Controls.Add(this.lbl3);
            this.book.Controls.Add(this.label10);
            this.book.Controls.Add(this.lbl2);
            this.book.Controls.Add(this.label11);
            this.book.Controls.Add(this.lbl1);
            this.book.Location = new System.Drawing.Point(481, 80);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(148, 159);
            this.book.TabIndex = 23;
            this.book.TabStop = false;
            this.book.Text = "Book";
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(555, 270);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(83, 23);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Back to Login";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(144, 241);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblliblogin
            // 
            this.lblliblogin.AutoSize = true;
            this.lblliblogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliblogin.Location = new System.Drawing.Point(239, 19);
            this.lblliblogin.Name = "lblliblogin";
            this.lblliblogin.Size = new System.Drawing.Size(180, 19);
            this.lblliblogin.TabIndex = 27;
            this.lblliblogin.Text = "BOOK MANAGEMENT";
            // 
            // Librairan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 305);
            this.Controls.Add(this.lblliblogin);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.book);
            this.Controls.Add(this.searchbook);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtpages);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Librairan";
            this.Text = "Libraian";
            this.searchbook.ResumeLayout(false);
            this.searchbook.PerformLayout();
            this.book.ResumeLayout(false);
            this.book.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.TextBox txtpages;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.GroupBox searchbook;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txttypeid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.GroupBox book;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblliblogin;
    }
}