
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
            this.dersprogrami = new System.Windows.Forms.DataGridView();
            this.back_to_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dersprogrami)).BeginInit();
            this.SuspendLayout();
            // 
            // dersprogrami
            // 
            this.dersprogrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersprogrami.Location = new System.Drawing.Point(4, 2);
            this.dersprogrami.Name = "dersprogrami";
            this.dersprogrami.RowHeadersWidth = 51;
            this.dersprogrami.RowTemplate.Height = 29;
            this.dersprogrami.Size = new System.Drawing.Size(699, 351);
            this.dersprogrami.TabIndex = 0;
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
            // ders_programi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 419);
            this.Controls.Add(this.back_to_home);
            this.Controls.Add(this.dersprogrami);
            this.Name = "ders_programi";
            this.Text = "ders_programi";
            ((System.ComponentModel.ISupportInitialize)(this.dersprogrami)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dersprogrami;
        private System.Windows.Forms.Button back_to_home;
    }
}