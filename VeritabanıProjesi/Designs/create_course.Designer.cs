
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fakulte = new System.Windows.Forms.TextBox();
            this.tb_bolum = new System.Windows.Forms.TextBox();
            this.tb_ders_adi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_on_create = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(648, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faculty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date:";
            // 
            // tb_fakulte
            // 
            this.tb_fakulte.Location = new System.Drawing.Point(179, 38);
            this.tb_fakulte.Name = "tb_fakulte";
            this.tb_fakulte.Size = new System.Drawing.Size(176, 27);
            this.tb_fakulte.TabIndex = 6;
            // 
            // tb_bolum
            // 
            this.tb_bolum.Location = new System.Drawing.Point(179, 86);
            this.tb_bolum.Name = "tb_bolum";
            this.tb_bolum.Size = new System.Drawing.Size(176, 27);
            this.tb_bolum.TabIndex = 7;
            // 
            // tb_ders_adi
            // 
            this.tb_ders_adi.Location = new System.Drawing.Point(179, 127);
            this.tb_ders_adi.Name = "tb_ders_adi";
            this.tb_ders_adi.Size = new System.Drawing.Size(176, 27);
            this.tb_ders_adi.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Thursday",
            "Tuesday",
            "Friday"});
            this.comboBox1.Location = new System.Drawing.Point(179, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 159);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(55, 230);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 21;
            // 
            // lbl_on_create
            // 
            this.lbl_on_create.AutoSize = true;
            this.lbl_on_create.ForeColor = System.Drawing.Color.Lime;
            this.lbl_on_create.Location = new System.Drawing.Point(391, 213);
            this.lbl_on_create.Name = "lbl_on_create";
            this.lbl_on_create.Size = new System.Drawing.Size(0, 20);
            this.lbl_on_create.TabIndex = 22;
            // 
            // create_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 481);
            this.Controls.Add(this.lbl_on_create);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_ders_adi);
            this.Controls.Add(this.tb_bolum);
            this.Controls.Add(this.tb_fakulte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "create_course";
            this.Text = "create_course";
            this.Load += new System.EventHandler(this.create_course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fakulte;
        private System.Windows.Forms.TextBox tb_bolum;
        private System.Windows.Forms.TextBox tb_ders_adi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_on_create;
    }
}