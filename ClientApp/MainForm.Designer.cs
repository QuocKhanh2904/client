﻿using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace ClientApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Setting = new FontAwesome.Sharp.IconButton();
            this.bt_Message = new FontAwesome.Sharp.IconButton();
            this.bt_User = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_UserChat = new System.Windows.Forms.Label();
            this.pic_User = new FontAwesome.Sharp.IconPictureBox();
            this.bt_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.flow_UserList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Typing = new System.Windows.Forms.Panel();
            this.bt_Gift = new FontAwesome.Sharp.IconButton();
            this.bt_Send = new FontAwesome.Sharp.IconButton();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.bt_Exit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flow_chat = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_Typing.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.bt_Setting);
            this.panel1.Controls.Add(this.bt_Message);
            this.panel1.Controls.Add(this.bt_User);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 1096);
            this.panel1.TabIndex = 0;
            // 
            // bt_Setting
            // 
            this.bt_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.bt_Setting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.bt_Setting.IconColor = System.Drawing.Color.White;
            this.bt_Setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Setting.IconSize = 55;
            this.bt_Setting.Location = new System.Drawing.Point(0, 1010);
            this.bt_Setting.Name = "bt_Setting";
            this.bt_Setting.Size = new System.Drawing.Size(86, 86);
            this.bt_Setting.TabIndex = 2;
            this.bt_Setting.UseVisualStyleBackColor = true;
            // 
            // bt_Message
            // 
            this.bt_Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.bt_Message.IconChar = FontAwesome.Sharp.IconChar.Commenting;
            this.bt_Message.IconColor = System.Drawing.Color.White;
            this.bt_Message.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Message.IconSize = 55;
            this.bt_Message.Location = new System.Drawing.Point(0, 144);
            this.bt_Message.Name = "bt_Message";
            this.bt_Message.Size = new System.Drawing.Size(86, 86);
            this.bt_Message.TabIndex = 1;
            this.bt_Message.UseVisualStyleBackColor = true;
            // 
            // bt_User
            // 
            this.bt_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.bt_User.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.bt_User.IconColor = System.Drawing.Color.White;
            this.bt_User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_User.IconSize = 90;
            this.bt_User.Location = new System.Drawing.Point(0, 6);
            this.bt_User.Name = "bt_User";
            this.bt_User.Size = new System.Drawing.Size(86, 86);
            this.bt_User.TabIndex = 0;
            this.bt_User.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lb_UserChat);
            this.panel3.Controls.Add(this.pic_User);
            this.panel3.Controls.Add(this.bt_Search);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(86, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1673, 92);
            this.panel3.TabIndex = 2;
            // 
            // lb_UserChat
            // 
            this.lb_UserChat.AutoSize = true;
            this.lb_UserChat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserChat.ForeColor = System.Drawing.Color.White;
            this.lb_UserChat.Location = new System.Drawing.Point(610, 30);
            this.lb_UserChat.Name = "lb_UserChat";
            this.lb_UserChat.Size = new System.Drawing.Size(212, 33);
            this.lb_UserChat.TabIndex = 6;
            this.lb_UserChat.Text = "Chat with User";
            this.lb_UserChat.Visible = false;
            // 
            // pic_User
            // 
            this.pic_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_User.Enabled = false;
            this.pic_User.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pic_User.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.pic_User.IconColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pic_User.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.pic_User.IconSize = 90;
            this.pic_User.Location = new System.Drawing.Point(503, 6);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(90, 90);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_User.TabIndex = 4;
            this.pic_User.TabStop = false;
            this.pic_User.Visible = false;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.bt_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.bt_Search.IconColor = System.Drawing.Color.White;
            this.bt_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Search.IconSize = 40;
            this.bt_Search.Location = new System.Drawing.Point(6, 42);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(47, 37);
            this.bt_Search.TabIndex = 3;
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.White;
            this.txt_Search.Location = new System.Drawing.Point(59, 42);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(342, 42);
            this.txt_Search.TabIndex = 2;
            // 
            // flow_UserList
            // 
            this.flow_UserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.flow_UserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.flow_UserList.Location = new System.Drawing.Point(86, 92);
            this.flow_UserList.Name = "flow_UserList";
            this.flow_UserList.Size = new System.Drawing.Size(425, 1004);
            this.flow_UserList.TabIndex = 3;
            // 
            // panel_Typing
            // 
            this.panel_Typing.Controls.Add(this.bt_Gift);
            this.panel_Typing.Controls.Add(this.bt_Send);
            this.panel_Typing.Controls.Add(this.txt_Message);
            this.panel_Typing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Typing.Location = new System.Drawing.Point(511, 1010);
            this.panel_Typing.Name = "panel_Typing";
            this.panel_Typing.Size = new System.Drawing.Size(1248, 86);
            this.panel_Typing.TabIndex = 4;
            // 
            // bt_Gift
            // 
            this.bt_Gift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.bt_Gift.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.bt_Gift.IconColor = System.Drawing.Color.White;
            this.bt_Gift.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Gift.IconSize = 40;
            this.bt_Gift.Location = new System.Drawing.Point(6, 13);
            this.bt_Gift.Name = "bt_Gift";
            this.bt_Gift.Size = new System.Drawing.Size(81, 57);
            this.bt_Gift.TabIndex = 2;
            this.bt_Gift.UseVisualStyleBackColor = true;
            this.bt_Gift.Click += new System.EventHandler(this.bt_Gift_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.bt_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.bt_Send.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.bt_Send.IconColor = System.Drawing.Color.White;
            this.bt_Send.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Send.IconSize = 40;
            this.bt_Send.Location = new System.Drawing.Point(1167, 0);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(81, 86);
            this.bt_Send.TabIndex = 1;
            this.bt_Send.UseVisualStyleBackColor = false;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.Color.White;
            this.txt_Message.Location = new System.Drawing.Point(93, 15);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(1068, 57);
            this.txt_Message.TabIndex = 0;
            this.txt_Message.Tag = "";
            this.txt_Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Message_KeyDown);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.bt_Exit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.bt_Exit.IconColor = System.Drawing.Color.White;
            this.bt_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Exit.IconSize = 40;
            this.bt_Exit.Location = new System.Drawing.Point(253, 0);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(81, 46);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.bt_Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(1759, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 1096);
            this.panel2.TabIndex = 1;
            // 
            // flow_chat
            // 
            this.flow_chat.AutoSize = true;
            this.flow_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_chat.Location = new System.Drawing.Point(511, 92);
            this.flow_chat.Name = "flow_chat";
            this.flow_chat.Size = new System.Drawing.Size(1248, 918);
            this.flow_chat.TabIndex = 5;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1877, 1096);
            this.Controls.Add(this.flow_chat);
            this.Controls.Add(this.panel_Typing);
            this.Controls.Add(this.flow_UserList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zalo Chat - WinForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_Typing.ResumeLayout(false);
            this.panel_Typing.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Panel panel1;
        private IconButton bt_User;
        private Panel panel3;
        private FlowLayoutPanel flow_UserList;
        private IconButton bt_Setting;
        private IconButton bt_Message;
        private Panel panel_Typing;
        private IconButton bt_Send;
        private TextBox txt_Message;
        private IconButton bt_Gift;
        private IconButton bt_Search;
        private TextBox txt_Search;
        private IconPictureBox pic_User;
        private Label lb_UserChat;
        private IconButton bt_Exit;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel flow_chat;
    }
}

