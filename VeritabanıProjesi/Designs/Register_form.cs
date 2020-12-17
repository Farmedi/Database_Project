using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace VeritabanıProjesi
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

       

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool error = false;
            int index_of_at = eb_email.Text.IndexOf('@');
            string sonu = eb_email.Text.Substring(index_of_at + 1, eb_email.Text.Length );

            if (tb_name.Text.Length==0)
            {
                lbl_name_error.Text = "*Name is required.";
                error = true;
            }
            if (tb_surname.Text.Length==0)
            {
                lbl_surname_error.Text = "*Surname is required.";
                error = true;
            }
            if (eb_email.Text.Length==0 || index_of_at == -1 || !sonu.Contains(".com") )
            {
                lbl_email_error.Text = "*Email is invalid or left blank.";
                error = true;
            }

            if (tb_pw.Text.Length < 7)
            {
                lbl_pw_error.Text = "*Password should have more than 7 characters.";
                error = true;
            }
            if (tb_pw.Text != tb_cpw.Text)
            {
                lbl_pw_error.Text = "*Passwords don't match.";
                error = true;
            }
            if (!rb_student.Checked && !rb_teacher.Checked )
            {
                lbl_role.Text = "*Can't be left unchecked.";
                error = true;
            }

            if (!error)
            {
                string name = tb_name.Text;
                string surname = tb_surname.Text;
                string email = eb_email.Text;
                string password = tb_pw.Text.Trim();
                string role = "";
                string query = "";

                if (rb_student.Checked) { role = rb_student.Text; }
                if (rb_teacher.Checked) { role = rb_teacher.Text; }

                String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
                SqlConnection con = new SqlConnection(str);

                if (rb_student.Checked)
                {
                     query = "Insert into tbl_ogrenci(isim,soyisim,email,pw,roleid) values(" + name + "," + surname + "," + email + "," + password + ",1)";
                }
                if (rb_teacher.Checked)
                {
                    //string query = "Insert into tbl_ogretmen(isim,soyisim,email,pw,roleid) values(" + name + "," + surname + "," + email + "," + password + ",1)";
                    
                    using (SqlCommand cmd = new SqlCommand("ekle_ogretmen", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@isim", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@soyisim", SqlDbType.VarChar).Value = surname;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@roleid", SqlDbType.VarChar).Value = 1;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                /* string query = "Insert into"
                 
                 SqlCommand cmd = new SqlCommand(query, con);
                 con.Open();

                 con.Close();

                 */
            }



















            this.Close();
            
        }
    }
}
