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
    public partial class ogretmen_home : Form
    {
        public ogretmen_home()
        {
            InitializeComponent();
        }
        
        private void ogretmen_home_Load(object sender, EventArgs e)
        {
            label1.Text = "Name: " + Global.name + " " + Global.surname + "\n ID: " + Global.ID;
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            string query = "select * from tbl_duyurular where duyuru_id=1 order by tarih desc";
            SqlCommand cmd = new SqlCommand(query, con);

            var announcements = new List<duyurular>();
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    announcements.Add(new duyurular(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                   
                }
            }
            reader.Close();
            con.Close();
            foreach (duyurular dyr in announcements)
            {
                rtb_duyurular.Text+="Date: "+dyr.tarih+"\n";
                rtb_duyurular.Text += "From: " + dyr.yapan + "\n";
                rtb_duyurular.Text += "" + dyr.duyuru + "\n";
                rtb_duyurular.Text += "-----------------------------------------------------------------------------\n";
            }
        }



        private void create_announcement_Click(object sender, EventArgs e)
        {
            this.Close();
            var t = new Thread(() => Application.Run(new create_announcement()));
            t.Start();
            

        }

        private void create_course_Click(object sender, EventArgs e)
        {
            create_course cc = new create_course();
            cc.ShowDialog();
            
        }

        private void student_info_Click(object sender, EventArgs e)
        {
            teacher_info ti = new teacher_info();
            ti.ShowDialog();
            
        }

        private void course_management_Click(object sender, EventArgs e)
        {
            manage_courses mc = new manage_courses();
            mc.ShowDialog();
        }
    }
}
