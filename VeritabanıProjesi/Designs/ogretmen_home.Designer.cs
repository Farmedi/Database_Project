
namespace VeritabanıProjesi
{
    partial class ogretmen_home
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
            this.create_announcement = new System.Windows.Forms.Button();
            this.course_management = new System.Windows.Forms.Button();
            this.student_info = new System.Windows.Forms.Button();
            this.create_course = new System.Windows.Forms.Button();
            this.rtb_duyurular = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // create_announcement
            // 
            this.create_announcement.Location = new System.Drawing.Point(67, 262);
            this.create_announcement.Name = "create_announcement";
            this.create_announcement.Size = new System.Drawing.Size(288, 65);
            this.create_announcement.TabIndex = 0;
            this.create_announcement.Text = "Announce";
            this.create_announcement.UseVisualStyleBackColor = true;
            this.create_announcement.Click += new System.EventHandler(this.create_announcement_Click);
            // 
            // course_management
            // 
            this.course_management.Location = new System.Drawing.Point(421, 344);
            this.course_management.Name = "course_management";
            this.course_management.Size = new System.Drawing.Size(288, 65);
            this.course_management.TabIndex = 1;
            this.course_management.Text = "Course Management";
            this.course_management.UseVisualStyleBackColor = true;
            this.course_management.Click += new System.EventHandler(this.course_management_Click);
            // 
            // student_info
            // 
            this.student_info.Location = new System.Drawing.Point(67, 344);
            this.student_info.Name = "student_info";
            this.student_info.Size = new System.Drawing.Size(288, 65);
            this.student_info.TabIndex = 2;
            this.student_info.Text = "Teacher Credentials";
            this.student_info.UseVisualStyleBackColor = true;
            this.student_info.Click += new System.EventHandler(this.student_info_Click);
            // 
            // create_course
            // 
            this.create_course.Location = new System.Drawing.Point(421, 262);
            this.create_course.Name = "create_course";
            this.create_course.Size = new System.Drawing.Size(288, 65);
            this.create_course.TabIndex = 3;
            this.create_course.Text = "Create Courses";
            this.create_course.UseVisualStyleBackColor = true;
            this.create_course.Click += new System.EventHandler(this.create_course_Click);
            // 
            // rtb_duyurular
            // 
            this.rtb_duyurular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtb_duyurular.Location = new System.Drawing.Point(67, 33);
            this.rtb_duyurular.Name = "rtb_duyurular";
            this.rtb_duyurular.ReadOnly = true;
            this.rtb_duyurular.Size = new System.Drawing.Size(642, 196);
            this.rtb_duyurular.TabIndex = 4;
            this.rtb_duyurular.Text = "";
            // 
            // ogretmen_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_duyurular);
            this.Controls.Add(this.create_course);
            this.Controls.Add(this.student_info);
            this.Controls.Add(this.course_management);
            this.Controls.Add(this.create_announcement);
            this.Name = "ogretmen_home";
            this.Text = "ogretmen_home";
            this.Load += new System.EventHandler(this.ogretmen_home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_announcement;
        private System.Windows.Forms.Button course_management;
        private System.Windows.Forms.Button student_info;
        private System.Windows.Forms.Button create_course;
        private System.Windows.Forms.RichTextBox rtb_duyurular;
    }
}