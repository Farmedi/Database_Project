﻿
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
            this.pw_change = new System.Windows.Forms.Button();
            this.OO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_opw = new System.Windows.Forms.TextBox();
            this.tb_cpw = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_scs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pw_change
            // 
            this.pw_change.ForeColor = System.Drawing.Color.Crimson;
            this.pw_change.Location = new System.Drawing.Point(3, 236);
            this.pw_change.Name = "pw_change";
            this.pw_change.Size = new System.Drawing.Size(347, 47);
            this.pw_change.TabIndex = 0;
            this.pw_change.Text = "Change Password!";
            this.pw_change.UseVisualStyleBackColor = true;
            this.pw_change.Click += new System.EventHandler(this.button1_Click);
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
            // tb_opw
            // 
            this.tb_opw.Location = new System.Drawing.Point(149, 34);
            this.tb_opw.Name = "tb_opw";
            this.tb_opw.Size = new System.Drawing.Size(176, 27);
            this.tb_opw.TabIndex = 4;
            this.tb_opw.UseSystemPasswordChar = true;
            // 
            // tb_cpw
            // 
            this.tb_cpw.Location = new System.Drawing.Point(148, 104);
            this.tb_cpw.Name = "tb_cpw";
            this.tb_cpw.Size = new System.Drawing.Size(176, 27);
            this.tb_cpw.TabIndex = 5;
            this.tb_cpw.UseSystemPasswordChar = true;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(149, 68);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(176, 27);
            this.tb_pw.TabIndex = 6;
            this.tb_pw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // lbl_scs
            // 
            this.lbl_scs.AutoSize = true;
            this.lbl_scs.ForeColor = System.Drawing.Color.Lime;
            this.lbl_scs.Location = new System.Drawing.Point(92, 286);
            this.lbl_scs.Name = "lbl_scs";
            this.lbl_scs.Size = new System.Drawing.Size(0, 20);
            this.lbl_scs.TabIndex = 8;
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(351, 409);
            this.Controls.Add(this.lbl_scs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_cpw);
            this.Controls.Add(this.tb_opw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OO);
            this.Controls.Add(this.pw_change);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "change_password";
            this.Text = "change_password";
            this.Load += new System.EventHandler(this.change_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pw_change;
        private System.Windows.Forms.Label OO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_opw;
        private System.Windows.Forms.TextBox tb_cpw;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_scs;
    }
}