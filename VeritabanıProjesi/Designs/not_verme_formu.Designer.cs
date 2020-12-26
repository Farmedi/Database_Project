
namespace VeritabanıProjesi
{
    partial class not_verme_formu
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
            this.dgw_dersler = new System.Windows.Forms.DataGridView();
            this.Grading = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dersler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_dersler
            // 
            this.dgw_dersler.AllowUserToAddRows = false;
            this.dgw_dersler.AllowUserToDeleteRows = false;
            this.dgw_dersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_dersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grading});
            this.dgw_dersler.Location = new System.Drawing.Point(124, 23);
            this.dgw_dersler.Name = "dgw_dersler";
            this.dgw_dersler.RowHeadersWidth = 51;
            this.dgw_dersler.RowTemplate.Height = 29;
            this.dgw_dersler.Size = new System.Drawing.Size(802, 345);
            this.dgw_dersler.TabIndex = 0;
            this.dgw_dersler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_dersler_CellContentDoubleClick);
            // 
            // Grading
            // 
            this.Grading.HeaderText = "Grading";
            this.Grading.MinimumWidth = 6;
            this.Grading.Name = "Grading";
            this.Grading.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go Back.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_return.Location = new System.Drawing.Point(48, 23);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(80, 55);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "<---";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Visible = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // not_verme_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 468);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw_dersler);
            this.Name = "not_verme_formu";
            this.Text = "not_verme_formu";
            this.Load += new System.EventHandler(this.not_verme_formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_dersler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Grading;
        private System.Windows.Forms.Button btn_return;
    }
}