
namespace VeritabanıProjesi
{
    partial class create_announcement
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
            this.rtb_duyuru = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.rb_teacher = new System.Windows.Forms.RadioButton();
            this.lb_scs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Announcement:";
            // 
            // rtb_duyuru
            // 
            this.rtb_duyuru.Location = new System.Drawing.Point(213, 84);
            this.rtb_duyuru.Name = "rtb_duyuru";
            this.rtb_duyuru.Size = new System.Drawing.Size(407, 121);
            this.rtb_duyuru.TabIndex = 1;
            this.rtb_duyuru.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(213, 281);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 4;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(213, 54);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(107, 24);
            this.rb_student.TabIndex = 5;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "To Students";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // rb_teacher
            // 
            this.rb_teacher.AutoSize = true;
            this.rb_teacher.Location = new System.Drawing.Point(512, 54);
            this.rb_teacher.Name = "rb_teacher";
            this.rb_teacher.Size = new System.Drawing.Size(107, 24);
            this.rb_teacher.TabIndex = 6;
            this.rb_teacher.TabStop = true;
            this.rb_teacher.Text = "To Teachers";
            this.rb_teacher.UseVisualStyleBackColor = true;
            // 
            // lb_scs
            // 
            this.lb_scs.AutoSize = true;
            this.lb_scs.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_scs.Location = new System.Drawing.Point(493, 281);
            this.lb_scs.Name = "lb_scs";
            this.lb_scs.Size = new System.Drawing.Size(0, 20);
            this.lb_scs.TabIndex = 7;
            // 
            // create_announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_scs);
            this.Controls.Add(this.rb_teacher);
            this.Controls.Add(this.rb_student);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_duyuru);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "create_announcement";
            this.Text = "create_announcement";
            this.Load += new System.EventHandler(this.create_announcement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_duyuru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.RadioButton rb_teacher;
        private System.Windows.Forms.Label lb_scs;
    }
}