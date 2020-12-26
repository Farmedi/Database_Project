using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace VeritabanıProjesi
{
    public partial class create_course : Form
    {
        public create_course()
        {
            InitializeComponent();
        }

        private void create_course_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fakulte_adi = tb_fakulte.Text.Trim();
            string bolum_adi = tb_bolum.Text.Trim();
            string class_name = tb_ders_adi.Text.Trim();
            string error_message = "";
            lbl_error.Text = "";
            lbl_on_create.Text = "";

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            bool error = false;
            if (fakulte_adi.Length==0)
            {
                error = true;
                error_message += "Faculty name is required.\n";
            }
            if (bolum_adi.Length==0)
            {
                error = true;
                error_message += " Department name is required.\n";
            }
            if (class_name.Length==0)
            {
                error = true;
                error_message += "Class name is required.\n";
            }
            lbl_error.Text = error_message;
            if (!error)
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand("ekle_ders", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@fakultee", SqlDbType.VarChar).Value = fakulte_adi;
                        cmd.Parameters.Add("@bolumm", SqlDbType.VarChar).Value = bolum_adi;
                        cmd.Parameters.Add("@ders_adii", SqlDbType.VarChar).Value = class_name;
                        cmd.Parameters.Add("@ogretmen_adii", SqlDbType.VarChar).Value = Global.name + " " + Global.surname;
                        cmd.Parameters.Add("@ders_tarihii", SqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();

                        con.Open();
                        cmd.ExecuteNonQuery();
                        
                    }
                    lbl_on_create.Text = "Course created succesfully!";
                }
                catch (Exception ec)
                {
                    lbl_error.Text = ec.Message;

                }
            }

        }
    }
}
