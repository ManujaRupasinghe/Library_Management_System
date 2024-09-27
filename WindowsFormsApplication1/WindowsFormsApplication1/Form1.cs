using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            if (email == "libs@esoft.lk" && password == "Libs123")
            {
                MessageBox.Show("Login Success ! ");
                this.Hide();
                student obj = new student();
                obj.Show();
            }
            else if (email == "lec@esoft.lk" && password == "Lec123")
            {
                MessageBox.Show("Login Success ! ");
                this.Hide();
                lecture obj = new lecture();
                obj.Show();
            }
            else if (email == "libb@esoft.lk" && password == "Libb123")
            {
                MessageBox.Show("Login Success ! ");
                this.Hide();
                Librairan obj = new Librairan();
                obj.Show();
            }
            else if (email == "stu@esoft.lk" && password == "Stu123")
            {
                MessageBox.Show("Login Success ! ");
                this.Hide();
                newstudent obj = new newstudent();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success ! ");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemail.Text = "email";
            txtpassword.Text = "password";
            txtemail.Focus();
        }
    }
}
