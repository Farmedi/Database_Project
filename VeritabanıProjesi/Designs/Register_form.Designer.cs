
namespace VeritabanıProjesi
{
    partial class Register_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_teacher = new System.Windows.Forms.RadioButton();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.tb_cpw = new System.Windows.Forms.MaskedTextBox();
            this.tb_pw = new System.Windows.Forms.MaskedTextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.eb_email = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_name_error = new System.Windows.Forms.Label();
            this.lbl_surname_error = new System.Windows.Forms.Label();
            this.lbl_email_error = new System.Windows.Forms.Label();
            this.lbl_pw_error = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_exception = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // rb_teacher
            // 
            this.rb_teacher.AutoSize = true;
            this.rb_teacher.Location = new System.Drawing.Point(387, 373);
            this.rb_teacher.Name = "rb_teacher";
            this.rb_teacher.Size = new System.Drawing.Size(81, 24);
            this.rb_teacher.TabIndex = 5;
            this.rb_teacher.TabStop = true;
            this.rb_teacher.Text = "Teacher";
            this.rb_teacher.UseVisualStyleBackColor = true;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(240, 373);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(81, 24);
            this.rb_student.TabIndex = 6;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // tb_cpw
            // 
            this.tb_cpw.Location = new System.Drawing.Point(327, 280);
            this.tb_cpw.Name = "tb_cpw";
            this.tb_cpw.Size = new System.Drawing.Size(215, 27);
            this.tb_cpw.TabIndex = 7;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(327, 237);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(215, 27);
            this.tb_pw.TabIndex = 8;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(305, 141);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(237, 27);
            this.tb_surname.TabIndex = 10;
            // 
            // eb_email
            // 
            this.eb_email.Location = new System.Drawing.Point(305, 191);
            this.eb_email.Name = "eb_email";
            this.eb_email.Size = new System.Drawing.Size(237, 27);
            this.eb_email.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(305, 92);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(237, 27);
            this.tb_name.TabIndex = 12;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(182, 403);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(359, 47);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_name_error
            // 
            this.lbl_name_error.AutoSize = true;
            this.lbl_name_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_name_error.Location = new System.Drawing.Point(548, 99);
            this.lbl_name_error.Name = "lbl_name_error";
            this.lbl_name_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_name_error.TabIndex = 14;
            // 
            // lbl_surname_error
            // 
            this.lbl_surname_error.AutoSize = true;
            this.lbl_surname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_surname_error.Location = new System.Drawing.Point(548, 148);
            this.lbl_surname_error.Name = "lbl_surname_error";
            this.lbl_surname_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_surname_error.TabIndex = 15;
            // 
            // lbl_email_error
            // 
            this.lbl_email_error.AutoSize = true;
            this.lbl_email_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_email_error.Location = new System.Drawing.Point(548, 194);
            this.lbl_email_error.Name = "lbl_email_error";
            this.lbl_email_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_email_error.TabIndex = 16;
            // 
            // lbl_pw_error
            // 
            this.lbl_pw_error.AutoSize = true;
            this.lbl_pw_error.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_pw_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_pw_error.Location = new System.Drawing.Point(240, 324);
            this.lbl_pw_error.Name = "lbl_pw_error";
            this.lbl_pw_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_pw_error.TabIndex = 17;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(482, 337);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(0, 20);
            this.lbl_role.TabIndex = 18;
            // 
            // lbl_exception
            // 
            this.lbl_exception.AutoSize = true;
            this.lbl_exception.ForeColor = System.Drawing.Color.Red;
            this.lbl_exception.Location = new System.Drawing.Point(182, 463);
            this.lbl_exception.Name = "lbl_exception";
            this.lbl_exception.Size = new System.Drawing.Size(0, 20);
            this.lbl_exception.TabIndex = 19;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 553);
            this.Controls.Add(this.lbl_exception);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_pw_error);
            this.Controls.Add(this.lbl_email_error);
            this.Controls.Add(this.lbl_surname_error);
            this.Controls.Add(this.lbl_name_error);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.eb_email);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_cpw);
            this.Controls.Add(this.rb_student);
            this.Controls.Add(this.rb_teacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register_form";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_teacher;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.MaskedTextBox tb_cpw;
        private System.Windows.Forms.MaskedTextBox tb_pw;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox eb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_name_error;
        private System.Windows.Forms.Label lbl_surname_error;
        private System.Windows.Forms.Label lbl_email_error;
        private System.Windows.Forms.Label lbl_pw_error;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_exception;
    }
}