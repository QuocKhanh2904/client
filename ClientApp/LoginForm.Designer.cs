using System.Drawing;
using System.Windows.Forms;

namespace ClientApp
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Exit = new FontAwesome.Sharp.IconButton();
            this.bt_Login = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_Password);
            this.panel4.Controls.Add(this.lb_Password);
            this.panel4.Location = new System.Drawing.Point(13, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 72);
            this.panel4.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(244, 10);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(446, 45);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.Color.White;
            this.lb_Password.Location = new System.Drawing.Point(44, 10);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(175, 45);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Password:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_Exit);
            this.panel3.Controls.Add(this.bt_Login);
            this.panel3.Location = new System.Drawing.Point(15, 191);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 78);
            this.panel3.TabIndex = 0;
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.bt_Exit.IconColor = System.Drawing.Color.Red;
            this.bt_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Exit.IconSize = 40;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.Location = new System.Drawing.Point(534, 4);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(157, 58);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.bt_Login.IconColor = System.Drawing.Color.ForestGreen;
            this.bt_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Login.IconSize = 40;
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(345, 4);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(148, 58);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.lb_UserName);
            this.panel2.Location = new System.Drawing.Point(13, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 92);
            this.panel2.TabIndex = 0;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(244, 35);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(446, 45);
            this.txt_UserName.TabIndex = 1;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.ForeColor = System.Drawing.Color.White;
            this.lb_UserName.Location = new System.Drawing.Point(44, 35);
            this.lb_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(194, 45);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "User name:";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.CancelButton = this.bt_Exit;
            this.ClientSize = new System.Drawing.Size(758, 281);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private TextBox txt_Password;
        private Label lb_Password;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton bt_Exit;
        private Panel panel2;
        private TextBox txt_UserName;
        private Label lb_UserName;
        private FontAwesome.Sharp.IconButton bt_Login;
    }
}