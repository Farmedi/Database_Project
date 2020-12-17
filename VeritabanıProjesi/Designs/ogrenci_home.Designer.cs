
namespace VeritabanıProjesi
{
    partial class ogrenci_home
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
            this.ders_programi = new System.Windows.Forms.Button();
            this.ders_secimi = new System.Windows.Forms.Button();
            this.ogrenci_bilgileri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.duyurular = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ders_programi
            // 
            this.ders_programi.Location = new System.Drawing.Point(69, 327);
            this.ders_programi.Name = "ders_programi";
            this.ders_programi.Size = new System.Drawing.Size(211, 48);
            this.ders_programi.TabIndex = 1;
            this.ders_programi.Text = "Weekly Schedule";
            this.ders_programi.UseVisualStyleBackColor = true;
            this.ders_programi.Click += new System.EventHandler(this.ders_programi_Click);
            // 
            // ders_secimi
            // 
            this.ders_secimi.Location = new System.Drawing.Point(534, 327);
            this.ders_secimi.Name = "ders_secimi";
            this.ders_secimi.Size = new System.Drawing.Size(211, 48);
            this.ders_secimi.TabIndex = 2;
            this.ders_secimi.Text = "Class Selection";
            this.ders_secimi.UseVisualStyleBackColor = true;
            this.ders_secimi.Click += new System.EventHandler(this.ders_secimi_Click);
            // 
            // ogrenci_bilgileri
            // 
            this.ogrenci_bilgileri.Location = new System.Drawing.Point(301, 327);
            this.ogrenci_bilgileri.Name = "ogrenci_bilgileri";
            this.ogrenci_bilgileri.Size = new System.Drawing.Size(211, 48);
            this.ogrenci_bilgileri.TabIndex = 3;
            this.ogrenci_bilgileri.Text = "Student Info";
            this.ogrenci_bilgileri.UseVisualStyleBackColor = true;
            this.ogrenci_bilgileri.Click += new System.EventHandler(this.ogrenci_bilgileri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // duyurular
            // 
            this.duyurular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.duyurular.ForeColor = System.Drawing.SystemColors.Desktop;
            this.duyurular.Location = new System.Drawing.Point(69, 37);
            this.duyurular.Name = "duyurular";
            this.duyurular.ReadOnly = true;
            this.duyurular.Size = new System.Drawing.Size(676, 219);
            this.duyurular.TabIndex = 5;
            this.duyurular.Text = "";
            // 
            // ogrenci_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duyurular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenci_bilgileri);
            this.Controls.Add(this.ders_secimi);
            this.Controls.Add(this.ders_programi);
            this.Name = "ogrenci_home";
            this.Text = "ogrenci_home";
            this.Load += new System.EventHandler(this.ogrenci_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ders_programi;
        private System.Windows.Forms.Button ders_secimi;
        private System.Windows.Forms.Button ogrenci_bilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox duyurular;
    }
}