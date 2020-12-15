using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class manage_courses : Form
    {
        public manage_courses()
        {
            InitializeComponent();
        }

        private void manage_courses_Load(object sender, EventArgs e)
        {

        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
