using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabanıProjesi
{
    public partial class teacher_info : Form
    {
        public teacher_info()
        {
            InitializeComponent();
        }

        private void teacher_info_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Global.name;
            lbl_surname.Text = Global.surname;
            lbl_id.Text = Global.ID;

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);

            try
            {
                using (SqlCommand cmd = new SqlCommand("return_email_from_teacher", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value =Convert.ToUInt32(Global.ID);
                    cmd.Parameters.Add(parameter);
                    //cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.ID;

                    SqlParameter retval = cmd.Parameters.Add("@email", SqlDbType.VarChar,30);
                    retval.Direction = ParameterDirection.Output;

                     cmd.ExecuteNonQuery();
                    string ret = string.Empty;
                    ret = (string)cmd.Parameters["@email"].Value;
                    lbl_email.Text = ret;
                    con.Close();
                }
            }
            catch (Exception ec)
            {

                throw ec;
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password();
            cp.ShowDialog();
        }
    }
}
