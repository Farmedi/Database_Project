
namespace VeritabanıProjesi
{
    partial class create_course
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
            this.verilen_dersler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verilen_dersler)).BeginInit();
            this.SuspendLayout();
            // 
            // verilen_dersler
            // 
            this.verilen_dersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verilen_dersler.Location = new System.Drawing.Point(35, 33);
            this.verilen_dersler.Name = "verilen_dersler";
            this.verilen_dersler.RowHeadersWidth = 51;
            this.verilen_dersler.RowTemplate.Height = 29;
            this.verilen_dersler.Size = new System.Drawing.Size(735, 282);
            this.verilen_dersler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // create_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verilen_dersler);
            this.Name = "create_course";
            this.Text = "create_course";
            this.Load += new System.EventHandler(this.create_course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verilen_dersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView verilen_dersler;
        private System.Windows.Forms.Button button1;
    }
}