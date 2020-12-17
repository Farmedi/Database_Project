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
    public partial class create_announcement : Form
    {
        public create_announcement()
        {
            InitializeComponent();
        }

        private void create_announcement_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var t = new Thread(() => Application.Run(new ogretmen_home()));
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            lbl_error.Text = "";
            string duyuru = rtb_duyuru.Text;
            bool error = false;
            int kime=0;
            if (rb_student.Checked)
            {
                kime = 2;
            }
            else if (rb_teacher.Checked)
            {
                kime = 1;
            }
            if (duyuru.Length==0 || duyuru.Length>120)
            {
                lbl_error.Text = "Announcement can't be empty or more than 120 characters long.";
                error = true;
            }
            if(!rb_teacher.Checked && !rb_student.Checked) { lbl_error.Text = "Please choose whome are you posting this for."; error = true; }

            if (!error)
            {


                try
                {
                    using (SqlCommand cmd = new SqlCommand("ekle_duyuru", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@yapan", SqlDbType.VarChar).Value = Global.name + " " + Global.surname;
                        cmd.Parameters.Add("@duyuru", SqlDbType.VarChar).Value = duyuru;
                        cmd.Parameters.Add("@duyuru_id", SqlDbType.Int).Value = kime;

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                    lb_scs.Text = "Announcement has been posted succesfully!";
                }
                catch (Exception ec)
                {
                    lbl_error.Text = ec.Message;

                }
            }


        }
    }
}
