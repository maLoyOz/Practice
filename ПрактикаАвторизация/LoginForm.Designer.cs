using System;

namespace ПрактикаАвторизация
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBox_user = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_password = new MetroFramework.Controls.MetroTextBox();
            //this.metroTextBox_login = new MetroFramework.Controls.MetroTextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.metroButton_login = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ПрактикаАвторизация.Properties.Resources.вк;
            this.pictureBox1.Location = new System.Drawing.Point(121, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBox_user
            // 
            this.metroTextBox_user.Location = new System.Drawing.Point(121, 288);
            this.metroTextBox_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox_user.Name = "metroTextBox_user";
            this.metroTextBox_user.Size = new System.Drawing.Size(267, 28);
            this.metroTextBox_user.TabIndex = 1;
            // 
            // metroTextBox_password
            // 
            this.metroTextBox_password.Location = new System.Drawing.Point(121, 379);
            this.metroTextBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox_password.Name = "metroTextBox_password";
            this.metroTextBox_password.PasswordChar = '*';
            this.metroTextBox_password.Size = new System.Drawing.Size(267, 28);
            this.metroTextBox_password.TabIndex = 2;
            // 
            // metroTextBox_login
            // 
            //this.metroTextBox_login.Location = new System.Drawing.Point(0, 0);
            //this.metroTextBox_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.metroTextBox_login.Name = "metroTextBox_login";
            //this.metroTextBox_login.Size = new System.Drawing.Size(0, 27);
            //this.metroTextBox_login.TabIndex = 6;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(117, 254);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(33, 16);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "user";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(117, 347);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(66, 16);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "password";
            // 
            // metroButton_login
            // 
            this.metroButton_login.Location = new System.Drawing.Point(395, 448);
            this.metroButton_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton_login.Name = "metroButton_login";
            this.metroButton_login.Size = new System.Drawing.Size(100, 28);
            this.metroButton_login.TabIndex = 0;
            this.metroButton_login.Text = "Login";
            this.metroButton_login.Click += new System.EventHandler(this.metroButton_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 554);
            this.Controls.Add(this.metroButton_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            //this.Controls.Add(this.metroTextBox_login);
            this.Controls.Add(this.metroTextBox_password);
            this.Controls.Add(this.metroTextBox_user);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_user;
        private MetroFramework.Controls.MetroTextBox metroTextBox_password;
       // private MetroFramework.Controls.MetroTextBox metroTextBox_login;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private MetroFramework.Controls.MetroButton metroButton_login;
    }
}