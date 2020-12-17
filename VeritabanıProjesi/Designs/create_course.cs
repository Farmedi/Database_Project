using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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



        }
    }
}
