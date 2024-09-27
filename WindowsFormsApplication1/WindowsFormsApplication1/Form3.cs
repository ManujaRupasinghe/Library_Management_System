using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class lecture : Form
    {
        public lecture()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Desktop\project-esoft\WindowsFormsApplication1\WindowsFormsApplication1\BooksDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnbsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = txtsearch.Text;
                string query_search = "SELECT * FROM Book WHERE book_id=" + id + "";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    lbl1.Text = r[0].ToString();
                    lbl2.Text = r[1].ToString();
                    lbl3.Text = r[2].ToString();
                    lbl4.Text = r[3].ToString();
                    lbl5.Text = r[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Seaching " + ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnssearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string student_id = txtseach.Text;
                string query_search = "SELECT * FROM Student WHERE student_id='" + student_id + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    lbl6.Text = r[0].ToString();
                    lbl7.Text = r[1].ToString();
                    lbl8.Text = r[2].ToString();
                    lbl9.Text = r[3].ToString();
                    string gender = r[4].ToString();
                    if (gender == "Male")
                    {
                        male.Checked = true;
                    }
                    else
                    {
                        female.Checked = true;
                    }
                    lbl11.Text = r[5].ToString(); ;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while saving" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
