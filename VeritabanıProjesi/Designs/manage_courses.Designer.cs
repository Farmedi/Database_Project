
namespace VeritabanıProjesi
{
    partial class manage_courses
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
            this.dersprogrami = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dersprogrami)).BeginInit();
            this.SuspendLayout();
            // 
            // back_to_home
            // 
            this.back_to_home.Location = new System.Drawing.Point(269, 386);
            this.back_to_home.Name = "back_to_home";
            this.back_to_home.Size = new System.Drawing.Size(274, 42);
            this.back_to_home.TabIndex = 3;
            this.back_to_home.Text = "Go Back";
            this.back_to_home.UseVisualStyleBackColor = true;
            this.back_to_home.Click += new System.EventHandler(this.back_to_home_Click);
            // 
            // dersprogrami
            // 
            this.dersprogrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersprogrami.Location = new System.Drawing.Point(51, 23);
            this.dersprogrami.Name = "dersprogrami";
            this.dersprogrami.RowHeadersWidth = 51;
            this.dersprogrami.RowTemplate.Height = 29;
            this.dersprogrami.Size = new System.Drawing.Size(699, 351);
            this.dersprogrami.TabIndex = 2;
            // 
            // manage_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_to_home);
            this.Controls.Add(this.dersprogrami);
            this.Name = "manage_courses";
            this.Text = "manage_courses";
            this.Load += new System.EventHandler(this.manage_courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersprogrami)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_to_home;
        private System.Windows.Forms.DataGridView dersprogrami;
    }
}