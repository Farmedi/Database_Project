
namespace VeritabanıProjesi
{
    partial class ders_programi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_to_home = new System.Windows.Forms.Button();
            this.rtb_dersler = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // back_to_home
            // 
            this.back_to_home.Location = new System.Drawing.Point(222, 365);
            this.back_to_home.Name = "back_to_home";
            this.back_to_home.Size = new System.Drawing.Size(274, 42);
            this.back_to_home.TabIndex = 1;
            this.back_to_home.Text = "Go Back";
            this.back_to_home.UseVisualStyleBackColor = true;
            this.back_to_home.Click += new System.EventHandler(this.back_to_home_Click);
            // 
            // rtb_dersler
            // 
            this.rtb_dersler.BackColor = System.Drawing.Color.Orange;
            this.rtb_dersler.Location = new System.Drawing.Point(25, 12);
            this.rtb_dersler.Name = "rtb_dersler";
            this.rtb_dersler.ReadOnly = true;
            this.rtb_dersler.Size = new System.Drawing.Size(657, 333);
            this.rtb_dersler.TabIndex = 2;
            this.rtb_dersler.Text = "";
            // 
            // ders_programi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 419);
            this.Controls.Add(this.rtb_dersler);
            this.Controls.Add(this.back_to_home);
            this.Name = "ders_programi";
            this.Text = "ders_programi";
            this.Load += new System.EventHandler(this.ders_programi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_to_home;
        private System.Windows.Forms.RichTextBox rtb_dersler;
    }
}