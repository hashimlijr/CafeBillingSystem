using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBillingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
            panel_LoginPassword.Visible = false;
            panel_LoginName.Visible = true;
        }
        string windr = Path.GetDirectoryName(Application.ExecutablePath);
        public bool NameExists(string name)
        {
            string namepath = windr + @"\database" + @"\" + name;

            if (Directory.Exists(namepath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Lpb_NextToPassword_Click(object sender, EventArgs e)
        {
            if(LtextBox_EnterCafeName.Text != "")
            {
                if (NameExists(LtextBox_EnterCafeName.Text.ToUpper()))
                {
                    panel_LoginPassword.Visible = true;
                    panel_LoginName.Visible = false;
                }
                else
                {
                    Llabel_NameError.Text = "*This cafe name is not registered";
                }
            }
            else
            {
                Llabel_NameError.Text = "*Please enter a name";
            }
        }

        public bool PasswordMatch(string enterpassword)
        {
            string path = windr + @"\database" + @"\" + LtextBox_EnterCafeName.Text.ToUpper() + @"\data.txt";
            string password = File.ReadLines(path).Last();
            if (enterpassword == password)
            {
                return true;             
            }
            else
            {              
                return false;
            }
            
        }
        private void lpb_Login_Click(object sender, EventArgs e)
        {
            if(ltextBox_Password.Text != "")
            {
                if (PasswordMatch(ltextBox_Password.Text))
                {
                    CBS cbs = new CBS(LtextBox_EnterCafeName.Text);
                    cbs.Show();
                    this.Hide();
                }
                else
                {
                    label_LoginPasswordError.Text = "*Invalid password";
                }
            }
            else
            {
                label_LoginPasswordError.Text = "*Enter password";
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void lpb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void lpb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_LBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lpb_Password_Click(object sender, EventArgs e)
        {
            panel_LoginPassword.Visible = false;
            panel_LoginName.Visible = true;
        }

        private void lpb_LoginToRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_ToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
