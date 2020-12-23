
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
            this.my_courses = new System.Windows.Forms.DataGridView();
            this.delete_course = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.my_courses)).BeginInit();
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
            // my_courses
            // 
            this.my_courses.AllowUserToAddRows = false;
            this.my_courses.AllowUserToDeleteRows = false;
            this.my_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete_course});
            this.my_courses.Location = new System.Drawing.Point(1, 5);
            this.my_courses.Name = "my_courses";
            this.my_courses.ReadOnly = true;
            this.my_courses.RowHeadersWidth = 51;
            this.my_courses.RowTemplate.Height = 29;
            this.my_courses.Size = new System.Drawing.Size(797, 369);
            this.my_courses.TabIndex = 2;
            this.my_courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.my_courses_CellContentClick);
            this.my_courses.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.my_courses_CellContentDoubleClick);
            // 
            // delete_course
            // 
            this.delete_course.HeaderText = "Delete Course";
            this.delete_course.MinimumWidth = 6;
            this.delete_course.Name = "delete_course";
            this.delete_course.ReadOnly = true;
            this.delete_course.Text = "Delete";
            this.delete_course.Width = 125;
            // 
            // manage_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_to_home);
            this.Controls.Add(this.my_courses);
            this.Name = "manage_courses";
            this.Text = "manage_courses";
            this.Load += new System.EventHandler(this.manage_courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_to_home;
        private System.Windows.Forms.DataGridView my_courses;
        private System.Windows.Forms.DataGridViewButtonColumn delete_course;
    }
}