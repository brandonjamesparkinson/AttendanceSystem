namespace Attendance_System
{
    partial class FrmRegister
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
            this.metroTextBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabelConfirmPassword = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAccept = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxUserName
            // 
            this.metroTextBoxUserName.Location = new System.Drawing.Point(30, 47);
            this.metroTextBoxUserName.Name = "metroTextBoxUserName";
            this.metroTextBoxUserName.Size = new System.Drawing.Size(213, 23);
            this.metroTextBoxUserName.TabIndex = 0;
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Location = new System.Drawing.Point(30, 113);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.Size = new System.Drawing.Size(213, 23);
            this.metroTextBoxPassword.TabIndex = 1;
            // 
            // metroTextBoxConfirmPassword
            // 
            this.metroTextBoxConfirmPassword.Location = new System.Drawing.Point(30, 170);
            this.metroTextBoxConfirmPassword.Name = "metroTextBoxConfirmPassword";
            this.metroTextBoxConfirmPassword.PasswordChar = '*';
            this.metroTextBoxConfirmPassword.Size = new System.Drawing.Size(213, 23);
            this.metroTextBoxConfirmPassword.TabIndex = 2;
            // 
            // metroLabelUsername
            // 
            this.metroLabelUsername.AutoSize = true;
            this.metroLabelUsername.Location = new System.Drawing.Point(30, 25);
            this.metroLabelUsername.Name = "metroLabelUsername";
            this.metroLabelUsername.Size = new System.Drawing.Size(78, 19);
            this.metroLabelUsername.TabIndex = 3;
            this.metroLabelUsername.Text = "User Name:";
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(30, 91);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(66, 19);
            this.metroLabelPassword.TabIndex = 4;
            this.metroLabelPassword.Text = "Password:";
            // 
            // metroLabelConfirmPassword
            // 
            this.metroLabelConfirmPassword.AutoSize = true;
            this.metroLabelConfirmPassword.Location = new System.Drawing.Point(30, 148);
            this.metroLabelConfirmPassword.Name = "metroLabelConfirmPassword";
            this.metroLabelConfirmPassword.Size = new System.Drawing.Size(118, 19);
            this.metroLabelConfirmPassword.TabIndex = 5;
            this.metroLabelConfirmPassword.Text = "Confirm Password:";
            // 
            // metroButtonAccept
            // 
            this.metroButtonAccept.Location = new System.Drawing.Point(168, 208);
            this.metroButtonAccept.Name = "metroButtonAccept";
            this.metroButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAccept.TabIndex = 6;
            this.metroButtonAccept.Text = "Accept";
            this.metroButtonAccept.Click += new System.EventHandler(this.metroButtonAccept_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 275);
            this.Controls.Add(this.metroButtonAccept);
            this.Controls.Add(this.metroLabelConfirmPassword);
            this.Controls.Add(this.metroLabelPassword);
            this.Controls.Add(this.metroLabelUsername);
            this.Controls.Add(this.metroTextBoxConfirmPassword);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxUserName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabelUsername;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabelConfirmPassword;
        private MetroFramework.Controls.MetroButton metroButtonAccept;
    }
}