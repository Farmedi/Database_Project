
namespace VeritabanıProjesi
{
    partial class ders_secimi
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
            this.ders_secim = new System.Windows.Forms.DataGridView();
            this.clm_add_class = new System.Windows.Forms.DataGridViewButtonColumn();
            this.go_home = new System.Windows.Forms.Button();
            this.cmb_faculty = new System.Windows.Forms.ComboBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.faculty_selection = new System.Windows.Forms.Label();
            this.department_selection = new System.Windows.Forms.Label();
            this.faculty_confirm = new System.Windows.Forms.Button();
            this.confirm_department = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ders_secim)).BeginInit();
            this.SuspendLayout();
            // 
            // ders_secim
            // 
            this.ders_secim.AllowUserToAddRows = false;
            this.ders_secim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ders_secim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ders_secim.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ders_secim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ders_secim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_add_class});
            this.ders_secim.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ders_secim.Location = new System.Drawing.Point(317, 107);
            this.ders_secim.Name = "ders_secim";
            this.ders_secim.RowHeadersWidth = 51;
            this.ders_secim.RowTemplate.Height = 29;
            this.ders_secim.Size = new System.Drawing.Size(540, 353);
            this.ders_secim.TabIndex = 0;
            this.ders_secim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ders_secim_CellContentClick);
            this.ders_secim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ders_secim_CellDoubleClick);
            // 
            // clm_add_class
            // 
            this.clm_add_class.HeaderText = "Sign Up ";
            this.clm_add_class.MinimumWidth = 6;
            this.clm_add_class.Name = "clm_add_class";
            this.clm_add_class.Text = "Join!";
            this.clm_add_class.UseColumnTextForButtonValue = true;
            this.clm_add_class.Width = 71;
            // 
            // go_home
            // 
            this.go_home.Location = new System.Drawing.Point(566, 466);
            this.go_home.Name = "go_home";
            this.go_home.Size = new System.Drawing.Size(252, 56);
            this.go_home.TabIndex = 1;
            this.go_home.Text = "Go Back";
            this.go_home.UseVisualStyleBackColor = true;
            this.go_home.Click += new System.EventHandler(this.go_home_Click);
            // 
            // cmb_faculty
            // 
            this.cmb_faculty.FormattingEnabled = true;
            this.cmb_faculty.Location = new System.Drawing.Point(130, 107);
            this.cmb_faculty.Name = "cmb_faculty";
            this.cmb_faculty.Size = new System.Drawing.Size(151, 28);
            this.cmb_faculty.TabIndex = 2;
            this.cmb_faculty.SelectedIndexChanged += new System.EventHandler(this.cmb_faculty_SelectedIndexChanged);
            // 
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(130, 297);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(151, 28);
            this.cmb_department.TabIndex = 3;
            // 
            // faculty_selection
            // 
            this.faculty_selection.AutoSize = true;
            this.faculty_selection.Location = new System.Drawing.Point(54, 115);
            this.faculty_selection.Name = "faculty_selection";
            this.faculty_selection.Size = new System.Drawing.Size(54, 20);
            this.faculty_selection.TabIndex = 4;
            this.faculty_selection.Text = "Faculty";
            // 
            // department_selection
            // 
            this.department_selection.AutoSize = true;
            this.department_selection.Location = new System.Drawing.Point(35, 305);
            this.department_selection.Name = "department_selection";
            this.department_selection.Size = new System.Drawing.Size(89, 20);
            this.department_selection.TabIndex = 5;
            this.department_selection.Text = "Department";
            // 
            // faculty_confirm
            // 
            this.faculty_confirm.Location = new System.Drawing.Point(188, 136);
            this.faculty_confirm.Name = "faculty_confirm";
            this.faculty_confirm.Size = new System.Drawing.Size(93, 35);
            this.faculty_confirm.TabIndex = 6;
            this.faculty_confirm.Text = "Confirm";
            this.faculty_confirm.UseVisualStyleBackColor = true;
            this.faculty_confirm.Click += new System.EventHandler(this.faculty_confirm_Click);
            // 
            // confirm_department
            // 
            this.confirm_department.Location = new System.Drawing.Point(191, 324);
            this.confirm_department.Name = "confirm_department";
            this.confirm_department.Size = new System.Drawing.Size(90, 35);
            this.confirm_department.TabIndex = 7;
            this.confirm_department.Text = "Confirm";
            this.confirm_department.UseVisualStyleBackColor = true;
            this.confirm_department.Click += new System.EventHandler(this.confirm_department_Click);
            // 
            // ders_secimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 521);
            this.Controls.Add(this.confirm_department);
            this.Controls.Add(this.faculty_confirm);
            this.Controls.Add(this.department_selection);
            this.Controls.Add(this.faculty_selection);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.cmb_faculty);
            this.Controls.Add(this.go_home);
            this.Controls.Add(this.ders_secim);
            this.Name = "ders_secimi";
            this.Text = "ders_secimi";
            this.Load += new System.EventHandler(this.ders_secimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ders_secim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ders_secim;
        private System.Windows.Forms.Button go_home;
        private System.Windows.Forms.ComboBox cmb_faculty;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label faculty_selection;
        private System.Windows.Forms.Label department_selection;
        private System.Windows.Forms.Button faculty_confirm;
        private System.Windows.Forms.Button confirm_department;
        private System.Windows.Forms.DataGridViewButtonColumn clm_add_class;
    }
}