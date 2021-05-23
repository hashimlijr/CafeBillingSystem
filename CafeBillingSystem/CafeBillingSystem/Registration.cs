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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        string windr = Path.GetDirectoryName(Application.ExecutablePath);
        public void CreateDirectory(string folderName)
        {
            string path = windr + @"\database" + @"\" + folderName;
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    label_NameError.Text = "*This name is already taken";
                    return;
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);                   
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel_RBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                            ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void rpb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void rpb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_ContinueToAddress_Click(object sender, EventArgs e)
        {
            if (textBox_EnterCafeName.Text != "")
            {
                panel_EnterCafeName.Visible = false;
                panel_Address.Visible = true;
                panel_ContactNumber.Visible = false;
                panel_Password.Visible = false;
            }
            else
            {
                label_NameError.Text = "*Please enter a name";
            }
        }

        private void pb_ContinueToNumber_Click(object sender, EventArgs e)
        {
            if (textBox_EnterAddress.Text != "")
            {
                panel_EnterCafeName.Visible = false;
                panel_Address.Visible = false;
                panel_ContactNumber.Visible = true;
                panel_Password.Visible = false;
            }
            else
            {
                label_AddressError.Text = "*Please enter an address";
            }
        }

        private void pb_ContinueToPassword_Click(object sender, EventArgs e)
        {
            if(textBox_Number.Text != "")
            {
                panel_EnterCafeName.Visible = false;
                panel_Address.Visible = false;
                panel_ContactNumber.Visible = false;
                panel_Password.Visible = true;
            }
            else
            {
                label_NumberError.Text = "*Please enter a contact number";
            }
        }

        public void CreateData(string address, string number, string password)
        {
            CreateDirectory(textBox_EnterCafeName.Text.ToUpper());
            string path = windr + @"\database" + @"\" + textBox_EnterCafeName.Text.ToUpper() + @"\data.txt";
            var myFile = File.Create(path);
            myFile.Close();
            StreamWriter sw = new StreamWriter(path);
            string data = address + Environment.NewLine + number + Environment.NewLine + password;
            sw.Write(data);
            sw.Close();
        }
        private void pb_ContinueToLoginPage_Click(object sender, EventArgs e)
        {
            try
            {
                CreateData(textBox_EnterAddress.Text, textBox_Number.Text, textBox_Password.Text);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void rpb_NumberToAddress_Click(object sender, EventArgs e)
        {
            panel_EnterCafeName.Visible = false;
            panel_Address.Visible = true;
            panel_ContactNumber.Visible = false;
            panel_Password.Visible = false;
        }

        private void rpb_RegisterToLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void rpb_AddressToName_Click(object sender, EventArgs e)
        {
            panel_EnterCafeName.Visible = true;
            panel_Address.Visible = false;
            panel_ContactNumber.Visible = false;
            panel_Password.Visible = false;
        }

        private void rpb_PasswordToNumber_Click(object sender, EventArgs e)
        {
            panel_EnterCafeName.Visible = false;
            panel_Address.Visible = false;
            panel_ContactNumber.Visible = true;
            panel_Password.Visible = false;
        }

        private void linkLabel_ToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
