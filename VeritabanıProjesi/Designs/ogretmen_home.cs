using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void create_announcement_Click(object sender, EventArgs e)
        {
            create_announcement ca = new create_announcement();
            ca.ShowDialog();
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
    }
}
