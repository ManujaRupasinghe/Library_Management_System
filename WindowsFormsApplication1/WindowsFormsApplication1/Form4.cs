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
    public partial class Librairan : Form
    {
        public Librairan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Desktop\project-esoft\WindowsFormsApplication1\WindowsFormsApplication1\BooksDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btninsert_Click(object sender, EventArgs e)
        {
            try 
            {
                string book_id = txtid.Text;
                string name = txtname.Text;
                string category = txtcategory.Text;
                string pages = txtpages.Text;
                string author = txtauthor.Text;
                string query_insert = "INSERT INTO Book Values ("+book_id+",'"+name+"','"+category+"',"+pages+",'"+author+"')";
                SqlCommand cmnd = new SqlCommand(query_insert,con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving"+ex);
            }
            finally 
            {
                con.Close();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string book_id = txttypeid.Text;
                string name = txtname.Text;
                string category = txtcategory.Text;
                string pages = txtpages.Text;
                string author = txtauthor.Text;
                string updatesql = "update Book set name='" + name + "',category='" + category + "',pages=" + pages + ",author='" + author + "'where book_id=" + book_id + "";
                SqlCommand cmnd = new SqlCommand(updatesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string id = lbl1.Text;
             
                string deletesql = "delete from Book where book_id=" + id + "";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();

            } 
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = txttypeid.Text;
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttypeid.Text = "";
            txtname.Text = "";
            txtcategory.Text = "";
            txtpages.Text = "";
            txtauthor.Text = "";
            txttypeid.Focus();
        }
    }
}
