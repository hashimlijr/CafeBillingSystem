
namespace CafeBillingSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_LBorder = new System.Windows.Forms.Panel();
            this.panel_LoginName = new System.Windows.Forms.Panel();
            this.linkLabel_ToRegister = new System.Windows.Forms.LinkLabel();
            this.Llabel_NameError = new System.Windows.Forms.Label();
            this.LtextBox_EnterCafeName = new PlaceholderTextBox.PlaceholderTextBox();
            this.label_RegisterTitle = new System.Windows.Forms.Label();
            this.panel_LoginPassword = new System.Windows.Forms.Panel();
            this.label_LoginPasswordError = new System.Windows.Forms.Label();
            this.ltextBox_Password = new PlaceholderTextBox.PlaceholderTextBox();
            this.Llabel_LoginPasswordTitle = new System.Windows.Forms.Label();
            this.lpb_Minimize = new System.Windows.Forms.PictureBox();
            this.lpb_Close = new System.Windows.Forms.PictureBox();
            this.Lpb_B = new System.Windows.Forms.PictureBox();
            this.Lpb_System = new System.Windows.Forms.PictureBox();
            this.Lpb_C = new System.Windows.Forms.PictureBox();
            this.LpictureBox_Background2 = new System.Windows.Forms.PictureBox();
            this.lpb_Password = new System.Windows.Forms.PictureBox();
            this.lpb_Login = new System.Windows.Forms.PictureBox();
            this.Lpb_Background = new System.Windows.Forms.PictureBox();
            this.Lpb_NextToPassword = new System.Windows.Forms.PictureBox();
            this.panel_LBorder.SuspendLayout();
            this.panel_LoginName.SuspendLayout();
            this.panel_LoginPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LpictureBox_Background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_NextToPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LBorder
            // 
            this.panel_LBorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_LBorder.Controls.Add(this.lpb_Minimize);
            this.panel_LBorder.Controls.Add(this.lpb_Close);
            this.panel_LBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LBorder.Location = new System.Drawing.Point(0, 0);
            this.panel_LBorder.Name = "panel_LBorder";
            this.panel_LBorder.Size = new System.Drawing.Size(757, 32);
            this.panel_LBorder.TabIndex = 8;
            this.panel_LBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_LBorder_MouseDown);
            // 
            // panel_LoginName
            // 
            this.panel_LoginName.Controls.Add(this.Lpb_Background);
            this.panel_LoginName.Controls.Add(this.linkLabel_ToRegister);
            this.panel_LoginName.Controls.Add(this.Llabel_NameError);
            this.panel_LoginName.Controls.Add(this.Lpb_NextToPassword);
            this.panel_LoginName.Controls.Add(this.LtextBox_EnterCafeName);
            this.panel_LoginName.Controls.Add(this.label_RegisterTitle);
            this.panel_LoginName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LoginName.Location = new System.Drawing.Point(0, 0);
            this.panel_LoginName.Name = "panel_LoginName";
            this.panel_LoginName.Size = new System.Drawing.Size(757, 550);
            this.panel_LoginName.TabIndex = 9;
            // 
            // linkLabel_ToRegister
            // 
            this.linkLabel_ToRegister.AutoSize = true;
            this.linkLabel_ToRegister.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel_ToRegister.Location = new System.Drawing.Point(306, 254);
            this.linkLabel_ToRegister.Name = "linkLabel_ToRegister";
            this.linkLabel_ToRegister.Size = new System.Drawing.Size(185, 17);
            this.linkLabel_ToRegister.TabIndex = 19;
            this.linkLabel_ToRegister.TabStop = true;
            this.linkLabel_ToRegister.Text = "Don\'t you have an account?";
            this.linkLabel_ToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ToRegister_LinkClicked);
            // 
            // Llabel_NameError
            // 
            this.Llabel_NameError.AutoSize = true;
            this.Llabel_NameError.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llabel_NameError.ForeColor = System.Drawing.Color.Red;
            this.Llabel_NameError.Location = new System.Drawing.Point(240, 227);
            this.Llabel_NameError.Name = "Llabel_NameError";
            this.Llabel_NameError.Size = new System.Drawing.Size(0, 19);
            this.Llabel_NameError.TabIndex = 13;
            // 
            // LtextBox_EnterCafeName
            // 
            this.LtextBox_EnterCafeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtextBox_EnterCafeName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtextBox_EnterCafeName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LtextBox_EnterCafeName.Location = new System.Drawing.Point(256, 187);
            this.LtextBox_EnterCafeName.Name = "LtextBox_EnterCafeName";
            this.LtextBox_EnterCafeName.PlaceholderText = "Enter your cafe name";
            this.LtextBox_EnterCafeName.Size = new System.Drawing.Size(259, 30);
            this.LtextBox_EnterCafeName.TabIndex = 10;
            this.LtextBox_EnterCafeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_RegisterTitle
            // 
            this.label_RegisterTitle.AutoSize = true;
            this.label_RegisterTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RegisterTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_RegisterTitle.Location = new System.Drawing.Point(275, 134);
            this.label_RegisterTitle.Name = "label_RegisterTitle";
            this.label_RegisterTitle.Size = new System.Drawing.Size(240, 26);
            this.label_RegisterTitle.TabIndex = 8;
            this.label_RegisterTitle.Text = "Welcome to CBSystem";
            // 
            // panel_LoginPassword
            // 
            this.panel_LoginPassword.Controls.Add(this.LpictureBox_Background2);
            this.panel_LoginPassword.Controls.Add(this.lpb_Password);
            this.panel_LoginPassword.Controls.Add(this.label_LoginPasswordError);
            this.panel_LoginPassword.Controls.Add(this.lpb_Login);
            this.panel_LoginPassword.Controls.Add(this.ltextBox_Password);
            this.panel_LoginPassword.Controls.Add(this.Llabel_LoginPasswordTitle);
            this.panel_LoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LoginPassword.Location = new System.Drawing.Point(0, 0);
            this.panel_LoginPassword.Name = "panel_LoginPassword";
            this.panel_LoginPassword.Size = new System.Drawing.Size(757, 550);
            this.panel_LoginPassword.TabIndex = 16;
            // 
            // label_LoginPasswordError
            // 
            this.label_LoginPasswordError.AutoSize = true;
            this.label_LoginPasswordError.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginPasswordError.ForeColor = System.Drawing.Color.Red;
            this.label_LoginPasswordError.Location = new System.Drawing.Point(240, 223);
            this.label_LoginPasswordError.Name = "label_LoginPasswordError";
            this.label_LoginPasswordError.Size = new System.Drawing.Size(0, 19);
            this.label_LoginPasswordError.TabIndex = 17;
            // 
            // ltextBox_Password
            // 
            this.ltextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltextBox_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltextBox_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ltextBox_Password.Location = new System.Drawing.Point(235, 188);
            this.ltextBox_Password.Name = "ltextBox_Password";
            this.ltextBox_Password.PlaceholderText = "Enter your password";
            this.ltextBox_Password.Size = new System.Drawing.Size(280, 30);
            this.ltextBox_Password.TabIndex = 15;
            this.ltextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Llabel_LoginPasswordTitle
            // 
            this.Llabel_LoginPasswordTitle.AutoSize = true;
            this.Llabel_LoginPasswordTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llabel_LoginPasswordTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Llabel_LoginPasswordTitle.Location = new System.Drawing.Point(187, 123);
            this.Llabel_LoginPasswordTitle.Name = "Llabel_LoginPasswordTitle";
            this.Llabel_LoginPasswordTitle.Size = new System.Drawing.Size(406, 26);
            this.Llabel_LoginPasswordTitle.TabIndex = 14;
            this.Llabel_LoginPasswordTitle.Text = "Good billing to you after the password!";
            // 
            // lpb_Minimize
            // 
            this.lpb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lpb_Minimize.Image = global::CafeBillingSystem.Properties.Resources.minus_4_;
            this.lpb_Minimize.Location = new System.Drawing.Point(688, -1);
            this.lpb_Minimize.Name = "lpb_Minimize";
            this.lpb_Minimize.Size = new System.Drawing.Size(30, 30);
            this.lpb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lpb_Minimize.TabIndex = 1;
            this.lpb_Minimize.TabStop = false;
            this.lpb_Minimize.Click += new System.EventHandler(this.lpb_Minimize_Click);
            // 
            // lpb_Close
            // 
            this.lpb_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lpb_Close.Image = global::CafeBillingSystem.Properties.Resources.cancel_5_;
            this.lpb_Close.Location = new System.Drawing.Point(724, 0);
            this.lpb_Close.Name = "lpb_Close";
            this.lpb_Close.Size = new System.Drawing.Size(30, 30);
            this.lpb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lpb_Close.TabIndex = 0;
            this.lpb_Close.TabStop = false;
            this.lpb_Close.Click += new System.EventHandler(this.lpb_Close_Click);
            // 
            // Lpb_B
            // 
            this.Lpb_B.BackColor = System.Drawing.Color.White;
            this.Lpb_B.Image = global::CafeBillingSystem.Properties.Resources.b;
            this.Lpb_B.Location = new System.Drawing.Point(357, 59);
            this.Lpb_B.Name = "Lpb_B";
            this.Lpb_B.Size = new System.Drawing.Size(64, 64);
            this.Lpb_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lpb_B.TabIndex = 14;
            this.Lpb_B.TabStop = false;
            // 
            // Lpb_System
            // 
            this.Lpb_System.BackColor = System.Drawing.Color.White;
            this.Lpb_System.Image = global::CafeBillingSystem.Properties.Resources.responsive;
            this.Lpb_System.Location = new System.Drawing.Point(427, 59);
            this.Lpb_System.Name = "Lpb_System";
            this.Lpb_System.Size = new System.Drawing.Size(64, 64);
            this.Lpb_System.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lpb_System.TabIndex = 15;
            this.Lpb_System.TabStop = false;
            // 
            // Lpb_C
            // 
            this.Lpb_C.BackColor = System.Drawing.Color.White;
            this.Lpb_C.Image = global::CafeBillingSystem.Properties.Resources.c;
            this.Lpb_C.Location = new System.Drawing.Point(287, 59);
            this.Lpb_C.Name = "Lpb_C";
            this.Lpb_C.Size = new System.Drawing.Size(64, 64);
            this.Lpb_C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lpb_C.TabIndex = 12;
            this.Lpb_C.TabStop = false;
            // 
            // LpictureBox_Background2
            // 
            this.LpictureBox_Background2.BackColor = System.Drawing.Color.White;
            this.LpictureBox_Background2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LpictureBox_Background2.Image = global::CafeBillingSystem.Properties.Resources.back4;
            this.LpictureBox_Background2.Location = new System.Drawing.Point(0, 265);
            this.LpictureBox_Background2.Name = "LpictureBox_Background2";
            this.LpictureBox_Background2.Size = new System.Drawing.Size(757, 285);
            this.LpictureBox_Background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LpictureBox_Background2.TabIndex = 19;
            this.LpictureBox_Background2.TabStop = false;
            // 
            // lpb_Password
            // 
            this.lpb_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lpb_Password.Image = global::CafeBillingSystem.Properties.Resources.previous;
            this.lpb_Password.Location = new System.Drawing.Point(13, 37);
            this.lpb_Password.Name = "lpb_Password";
            this.lpb_Password.Size = new System.Drawing.Size(36, 36);
            this.lpb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lpb_Password.TabIndex = 18;
            this.lpb_Password.TabStop = false;
            this.lpb_Password.Click += new System.EventHandler(this.lpb_Password_Click);
            // 
            // lpb_Login
            // 
            this.lpb_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lpb_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lpb_Login.Image = global::CafeBillingSystem.Properties.Resources.next;
            this.lpb_Login.Location = new System.Drawing.Point(521, 188);
            this.lpb_Login.Name = "lpb_Login";
            this.lpb_Login.Size = new System.Drawing.Size(35, 30);
            this.lpb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lpb_Login.TabIndex = 16;
            this.lpb_Login.TabStop = false;
            this.lpb_Login.Click += new System.EventHandler(this.lpb_Login_Click);
            // 
            // Lpb_Background
            // 
            this.Lpb_Background.BackColor = System.Drawing.Color.White;
            this.Lpb_Background.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lpb_Background.Image = global::CafeBillingSystem.Properties.Resources._6583;
            this.Lpb_Background.Location = new System.Drawing.Point(0, 309);
            this.Lpb_Background.Name = "Lpb_Background";
            this.Lpb_Background.Size = new System.Drawing.Size(757, 241);
            this.Lpb_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lpb_Background.TabIndex = 9;
            this.Lpb_Background.TabStop = false;
            // 
            // Lpb_NextToPassword
            // 
            this.Lpb_NextToPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lpb_NextToPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lpb_NextToPassword.Image = global::CafeBillingSystem.Properties.Resources.next;
            this.Lpb_NextToPassword.Location = new System.Drawing.Point(521, 187);
            this.Lpb_NextToPassword.Name = "Lpb_NextToPassword";
            this.Lpb_NextToPassword.Size = new System.Drawing.Size(35, 30);
            this.Lpb_NextToPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lpb_NextToPassword.TabIndex = 11;
            this.Lpb_NextToPassword.TabStop = false;
            this.Lpb_NextToPassword.Click += new System.EventHandler(this.Lpb_NextToPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 550);
            this.Controls.Add(this.panel_LBorder);
            this.Controls.Add(this.Lpb_B);
            this.Controls.Add(this.Lpb_System);
            this.Controls.Add(this.Lpb_C);
            this.Controls.Add(this.panel_LoginName);
            this.Controls.Add(this.panel_LoginPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_LBorder.ResumeLayout(false);
            this.panel_LoginName.ResumeLayout(false);
            this.panel_LoginName.PerformLayout();
            this.panel_LoginPassword.ResumeLayout(false);
            this.panel_LoginPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LpictureBox_Background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpb_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpb_NextToPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_LBorder;
        private System.Windows.Forms.PictureBox lpb_Minimize;
        private System.Windows.Forms.PictureBox lpb_Close;
        private System.Windows.Forms.Panel panel_LoginName;
        private System.Windows.Forms.Label Llabel_NameError;
        private System.Windows.Forms.PictureBox Lpb_NextToPassword;
        private PlaceholderTextBox.PlaceholderTextBox LtextBox_EnterCafeName;
        private System.Windows.Forms.Label label_RegisterTitle;
        private System.Windows.Forms.PictureBox Lpb_B;
        private System.Windows.Forms.PictureBox Lpb_C;
        private System.Windows.Forms.PictureBox Lpb_System;
        private System.Windows.Forms.PictureBox Lpb_Background;
        private System.Windows.Forms.Panel panel_LoginPassword;
        private System.Windows.Forms.Label label_LoginPasswordError;
        private System.Windows.Forms.PictureBox lpb_Login;
        private PlaceholderTextBox.PlaceholderTextBox ltextBox_Password;
        private System.Windows.Forms.Label Llabel_LoginPasswordTitle;
        private System.Windows.Forms.PictureBox lpb_Password;
        private System.Windows.Forms.LinkLabel linkLabel_ToRegister;
        private System.Windows.Forms.PictureBox LpictureBox_Background2;
    }
}