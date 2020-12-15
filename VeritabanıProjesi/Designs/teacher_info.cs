using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password();
            cp.ShowDialog();
        }
    }
}
