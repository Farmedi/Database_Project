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
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            
            //BAK BURAYA PW DOĞRU MU KONTROLÜNÜ YAP


            try
            {
                using (SqlCommand cmd = new SqlCommand("update_pw", con))
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
                }
            }
            catch (Exception ec)
            {

                throw ec;
            }
        }
    }
}
