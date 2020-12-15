
namespace VeritabanıProjesi
{
    partial class change_password
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
            this.OO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OO
            // 
            this.OO.AutoSize = true;
            this.OO.Location = new System.Drawing.Point(12, 34);
            this.OO.Name = "OO";
            this.OO.Size = new System.Drawing.Size(105, 20);
            this.OO.TabIndex = 1;
            this.OO.Text = "Old Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 409);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OO);
            this.Controls.Add(this.button1);
            this.Name = "change_password";
            this.Text = "change_password";
            this.Load += new System.EventHandler(this.change_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}