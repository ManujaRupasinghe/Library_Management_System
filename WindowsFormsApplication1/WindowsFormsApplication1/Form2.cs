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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Desktop\project-esoft\WindowsFormsApplication1\WindowsFormsApplication1\BooksDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnssubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                string student_id = txtid.Text;
                string name = txtname.Text;
                string email = txtemail.Text;
                string tp = txttp.Text;
                string gender;
                if (male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string grade = txtgrade.Text;
                string query_insert = "INSERT INTO Student Values ("+student_id+",'" + name + "','" + email + "'," + tp + ",'" + gender + "','" + grade + "')";
                SqlCommand cmnd = new SqlCommand(query_insert,con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Insert Successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while Saving!" + ex);
            }
            finally 
            {
                con.Close();
            }
        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {
            try 
            {
                string student_id = txtsearch.Text;
                //string student_id = txtid.Text;
                string name = txtname.Text;
                string email = txtemail.Text;
                string tp = txttp.Text;
                string gender;
                if (male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string grade = txtgrade.Text;
                string updatesql = "update Student set name='" + name + "',email='" + email + "',tp=" + tp + ",gender='" + gender + "',grade='" + grade + "' where student_id="+student_id+"";
                SqlCommand cmnd = new SqlCommand(updatesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully!");
            }
            
            catch(Exception ex)
            {
            MessageBox.Show("Error while saving"+ex);
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
        string student_id =txtsearch.Text;
        string query_search = "SELECT * FROM Student WHERE student_id='"+student_id+"'";
        SqlCommand cmnd = new SqlCommand(query_search,con);
        SqlDataReader r = cmnd.ExecuteReader();
        while(r.Read()){
            lbl1.Text = r[0].ToString();
            lbl2.Text = r[1].ToString();
            lbl3.Text = r[2].ToString();
            lbl4.Text = r[3].ToString();
            string gender = r[4].ToString();
                if (gender == "Male")
                {
                    male1.Checked = true;
                }
                else
                {
                    male1.Checked = true;
                }
            lbl5.Text =r[5].ToString();;
        }
        }

        catch(Exception ex)
        {
        MessageBox.Show("Error while saving"+ex);
        }
        finally
        {
        con.Close();
        }
        }

        private void btnsdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string student_id = txtsearch.Text;
                string deletesql = "delete from Student where student_id='" + student_id + "'";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
              
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
            con.Close();
            }
          }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void btnsbooks_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = txtsbooks.Text;
                string query_search = "SELECT * FROM Book WHERE book_id=" + id + "";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    lbl6.Text = r[0].ToString();
                    lbl7.Text = r[1].ToString();
                    lbl8.Text = r[2].ToString();
                    lbl9.Text = r[3].ToString();
                    lbl10.Text = r[4].ToString();
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txttp.Text= "";
            txtgrade.Text = "";
            txtid.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        }
    }

