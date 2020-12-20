namespace VeritabanıProjesi
{
    partial class Giris_Yonlendirme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Yonlendirme));
            this.ogretmen_login = new System.Windows.Forms.Button();
            this.Ogrenci_login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogretmen_login
            // 
            this.ogretmen_login.BackColor = System.Drawing.Color.Goldenrod;
            this.ogretmen_login.ForeColor = System.Drawing.Color.Cyan;
            this.ogretmen_login.Location = new System.Drawing.Point(249, 341);
            this.ogretmen_login.Name = "ogretmen_login";
            this.ogretmen_login.Size = new System.Drawing.Size(142, 51);
            this.ogretmen_login.TabIndex = 0;
            this.ogretmen_login.Text = "Teacher Login";
            this.ogretmen_login.UseVisualStyleBackColor = false;
            this.ogretmen_login.Click += new System.EventHandler(this.ogretmen_login_Click);
            // 
            // Ogrenci_login
            // 
            this.Ogrenci_login.BackColor = System.Drawing.Color.Goldenrod;
            this.Ogrenci_login.ForeColor = System.Drawing.Color.Cyan;
            this.Ogrenci_login.Location = new System.Drawing.Point(412, 341);
            this.Ogrenci_login.Name = "Ogrenci_login";
            this.Ogrenci_login.Size = new System.Drawing.Size(142, 51);
            this.Ogrenci_login.TabIndex = 1;
            this.Ogrenci_login.Text = "Student Login";
            this.Ogrenci_login.UseVisualStyleBackColor = false;
            this.Ogrenci_login.Click += new System.EventHandler(this.Ogrenci_login_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Goldenrod;
            this.Register.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register.ForeColor = System.Drawing.Color.Cyan;
            this.Register.Location = new System.Drawing.Point(214, 398);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(379, 40);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(322, 218);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(271, 27);
            this.tb_email.TabIndex = 3;
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(322, 269);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(271, 27);
            this.tb_pw.TabIndex = 4;
            this.tb_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(208, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            // 
            // lbl_login_error
            // 
            this.lbl_login_error.AutoSize = true;
            this.lbl_login_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_login_error.Location = new System.Drawing.Point(303, 299);
            this.lbl_login_error.Name = "lbl_login_error";
            this.lbl_login_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_login_error.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(210, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Istanbul X University";
            // 
            // Giris_Yonlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_login_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Ogrenci_login);
            this.Controls.Add(this.ogretmen_login);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Giris_Yonlendirme";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogretmen_login;
        private System.Windows.Forms.Button Ogrenci_login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_pww;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label lbl_login_error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

