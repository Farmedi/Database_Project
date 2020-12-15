
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
            this.duyurular = new System.Windows.Forms.DataGridView();
            this.ders_programi = new System.Windows.Forms.Button();
            this.ders_secimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // duyurular
            // 
            this.duyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.duyurular.Location = new System.Drawing.Point(22, 30);
            this.duyurular.Name = "duyurular";
            this.duyurular.RowHeadersWidth = 51;
            this.duyurular.RowTemplate.Height = 29;
            this.duyurular.Size = new System.Drawing.Size(754, 253);
            this.duyurular.TabIndex = 0;
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
            this.ders_secimi.Location = new System.Drawing.Point(529, 327);
            this.ders_secimi.Name = "ders_secimi";
            this.ders_secimi.Size = new System.Drawing.Size(211, 48);
            this.ders_secimi.TabIndex = 2;
            this.ders_secimi.Text = "Class Selection";
            this.ders_secimi.UseVisualStyleBackColor = true;
            this.ders_secimi.Click += new System.EventHandler(this.ders_secimi_Click);
            // 
            // ogrenci_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ders_secimi);
            this.Controls.Add(this.ders_programi);
            this.Controls.Add(this.duyurular);
            this.Name = "ogrenci_home";
            this.Text = "ogrenci_home";
            this.Load += new System.EventHandler(this.ogrenci_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView duyurular;
        private System.Windows.Forms.Button ders_programi;
        private System.Windows.Forms.Button ders_secimi;
    }
}