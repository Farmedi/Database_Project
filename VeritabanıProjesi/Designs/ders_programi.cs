using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class ders_programi : Form
    {
        public ders_programi()
        {
            InitializeComponent();
        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
