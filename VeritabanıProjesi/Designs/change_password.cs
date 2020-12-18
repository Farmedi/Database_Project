using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace VeritabanıProjesi
{
    public partial class change_password : Form
    {
        
        public change_password()
        {
            InitializeComponent();
        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { string current_pw = tb_opw.Text.Trim();
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            SqlDataReader dr;

            bool validate = true;

            using (SqlConnection con1 = new SqlConnection(str))
            {
                con1.Open();
                using (SqlCommand cmd1 = con1.CreateCommand())
                {
                    cmd1.CommandText = "select * from pw_return(@id,@pw)";
                    
                    cmd1.Parameters.AddWithValue("@id", Convert.ToInt32(Global.ID));
                    cmd1.Parameters.AddWithValue("@pw", current_pw);
                    cmd1.CommandType = CommandType.Text;
                    object s = cmd1.ExecuteScalar();
                    if (s==null)
                    {
                        label1.Text = "Incorrect current password.";
                        validate = false;
                    }
                    
                    con1.Close();
                }
            }

            



            if (validate)
            {
                if (tb_pw.Text!=tb_cpw.Text)
                {
                    label1.Text = "Passwords don't match!";
                }else if (tb_pw.Text.Length < 7) { label1.Text = "Your new password must be longer than 7 characters."; }
                else
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("update_pw_ogretmen", con))
                        {
                            con.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                            parameter.Direction = ParameterDirection.Input;
                            parameter.Value = Convert.ToUInt32(Global.ID);

                            SqlParameter p2 = new SqlParameter("@pw", SqlDbType.NVarChar);
                            p2.Direction = ParameterDirection.Input;
                            p2.Value = tb_pw.Text;
                            cmd.Parameters.Add(parameter);
                            cmd.Parameters.Add(p2);


                            cmd.ExecuteNonQuery();

                            con.Close();
                            lbl_scs.Text = "Password changed Succesfully!";
                        }
                    }
                    catch (Exception ec)
                    {

                        throw ec;
                    }
                }
               
            }
           
        }
    }
}
