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
    public partial class CBS : Form
    {
        public CBS(string cafeName)
        {
            InitializeComponent();
            label_CafeName.Text = cafeName.ToUpper();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnl_Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }         
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Americano.Text = "0";
            textBox_ButterCake.Text = "0";
            textBox_Cappuccino.Text = "0";
            textBox_Espresso.Text = "0";
            textBox_Latte.Text = "0";
            textBox_Macchiato.Text = "0";
            textBox_Mocha.Text = "0";
            textBox_PoundCake.Text = "0";
            textBox__AngelFoodCake.Text = "0";
            textBox__CheeseCake.Text = "0";
            textBox__GenoiseCake.Text = "0";
            textBox__SpongeCake.Text = "0";
            lblServiceCharge.Text = "1.00$";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            checkBox_Americano.Checked = false;
            checkBox_ButterCake.Checked = false;
            checkBox_Cappuccino.Checked = false;
            checkBox_Espresso.Checked = false;
            checkBox_Latte.Checked = false;
            checkBox_Macchiato.Checked = false;
            checkBox_Mocha.Checked = false;
            checkBox_PoundCake.Checked = false;
            checkBox_AngelFoodCake.Checked = false;
            checkBox_CheeseCake.Checked = false;
            checkBox_GenoiseCake.Checked = false;
            checkBox_SpongeCake.Checked = false;
        }

        private void button_Receipt_Click(object sender, EventArgs e)
        {
            //string windr = Path.GetDirectoryName(Application.ExecutablePath);
            // client = "receipt_" + placeholderTextBox_ClientName.Text + ".txt";
            //string path = windr + @"\database" + @"\" + label_CafeName.Text + @"\" + client;
            //StreamWriter receipt = new StreamWriter(path);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "receipt(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if(lblSubTotal.Text != "0")
                {
                    string receiptDetail = GetDetail();
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(receiptDetail);
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Please be sure that you fill areas right or try click \"Total\" button first.");
                }
            }
            //if (lblTotal.Text != "0")
            //{
            //    string receiptDetail = GetDetail();
            //    receipt.Write(receiptDetail);
            //    receipt.Close();
            //    MessageBox.Show("Receipt saved succesfully.");
            //}
                    
        }

        public string GetDetail()
        {
            string windr = Path.GetDirectoryName(Application.ExecutablePath);
            string path = windr + @"\database" + @"\" + label_CafeName.Text + @"\data.txt";
            StreamReader sw = new StreamReader(path);
            string address = sw.ReadLine();
            string phone = sw.ReadLine();

            string detail = "-------------------------------------------------------------" + Environment.NewLine +
                            "\t\t\t" + label_CafeName.Text + Environment.NewLine +
                            "-------------------------------------------------------------" + Environment.NewLine +
                            "Client Name     \t\t\t" + placeholderTextBox_ClientName.Text + Environment.NewLine +
                            "-------------------------------------------------------------" + Environment.NewLine +
                            "Latte           \t\t\t" + textBox_Latte.Text + Environment.NewLine +
                            "Cappuccino      \t\t\t" + textBox_Cappuccino.Text + Environment.NewLine +
                            "Americano       \t\t\t" + textBox_Americano.Text + Environment.NewLine +
                            "Espresso        \t\t\t" + textBox_Espresso.Text + Environment.NewLine +
                            "Mocha           \t\t\t" + textBox_Mocha.Text + Environment.NewLine +
                            "Macchiato       \t\t\t" + textBox_Macchiato.Text + Environment.NewLine +
                            "Butter Cake     \t\t\t" + textBox_ButterCake.Text + Environment.NewLine +
                            "Pound Cake      \t\t\t" + textBox_PoundCake.Text + Environment.NewLine +
                            "Sponge Cake     \t\t\t" + textBox__SpongeCake.Text + Environment.NewLine +
                            "Genoise Cake    \t\t\t" + textBox__GenoiseCake.Text + Environment.NewLine +
                            "Angel Food Cake \t\t\t" + textBox__AngelFoodCake.Text + Environment.NewLine +
                            "Cheese Cake     \t\t\t" + textBox__CheeseCake.Text + Environment.NewLine +
                            "-------------------------------------------------------------" + Environment.NewLine +
                            "Service Charge \t\t\t\t" + "1.00$" + Environment.NewLine +
                            "SubTotal       \t\t\t\t" + lblSubTotal.Text + Environment.NewLine +
                            "Total          \t\t\t\t" + lblTotal.Text + Environment.NewLine +
                            "-------------------------------------------------------------" + Environment.NewLine +
                            "\t\t" + address + "\t\t" + phone + Environment.NewLine +
                            "-------------------------------------------------------------" + Environment.NewLine;

            return detail;
        }
        private void CBS_Load(object sender, EventArgs e)
        {
            textBox_Americano.Text = "0";
            textBox_ButterCake.Text = "0";
            textBox_Cappuccino.Text = "0";
            textBox_Espresso.Text = "0";
            textBox_Latte.Text = "0";
            textBox_Macchiato.Text = "0";
            textBox_Mocha.Text = "0";
            textBox_PoundCake.Text = "0";
            textBox__AngelFoodCake.Text = "0";
            textBox__CheeseCake.Text = "0";
            textBox__GenoiseCake.Text = "0";
            textBox__SpongeCake.Text = "0";
            lblServiceCharge.Text = "1.00$";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            textBox_Americano.Enabled = false;
            textBox_ButterCake.Enabled = false;
            textBox_Cappuccino.Enabled = false;
            textBox_Espresso.Enabled = false;
            textBox_Latte.Enabled = false;
            textBox_Macchiato.Enabled = false;
            textBox_Mocha.Enabled = false;
            textBox_PoundCake.Enabled = false;
            textBox__AngelFoodCake.Enabled = false;
            textBox__CheeseCake.Enabled = false;
            textBox__GenoiseCake.Enabled = false;
            textBox__SpongeCake.Enabled = false;
        }

        private void button_Total_Click(object sender, EventArgs e)
        {
            double total = GetTotal();
            double subTotal = total - 1.00;

            lblServiceCharge.Text = "1.00$";
            lblTotal.Text = total.ToString() + "$";
            lblSubTotal.Text = subTotal.ToString() + "$";
        }

        public double GetTotal()
        {
            double latteP, cappuccinoP, americanoP, espressoP, mochaP, macchiatoP;
            double butterCP, poundCP, spongeCP, genoiseCP, angelfoodCP, cheeseCP;
            double tax;

            latteP = 1.50; cappuccinoP = 1.30; americanoP = 1.00; espressoP = 1.40; mochaP = 2.00; macchiatoP = 1.80;
            butterCP = 2.40; poundCP = 2.00; spongeCP = 2.10; genoiseCP = 2.20; angelfoodCP = 3.00; cheeseCP = 2.50;
            tax = 1.00;


            double latteN = Convert.ToDouble(textBox_Latte.Text);
            double cappuccinoN = Convert.ToDouble(textBox_Cappuccino.Text);
            double americanoN = Convert.ToDouble(textBox_Americano.Text);
            double espressoN = Convert.ToDouble(textBox_Espresso.Text);
            double mochaN = Convert.ToDouble(textBox_Mocha.Text);
            double macchiatoN = Convert.ToDouble(textBox_Macchiato.Text);

            double butterCN = Convert.ToDouble(textBox_ButterCake.Text);
            double poundCN = Convert.ToDouble(textBox_PoundCake.Text);
            double spongeCN = Convert.ToDouble(textBox__SpongeCake.Text);
            double genoiseCN = Convert.ToDouble(textBox__GenoiseCake.Text);
            double angelfoodCN = Convert.ToDouble(textBox__AngelFoodCake.Text);
            double cheeseCN = Convert.ToDouble(textBox__CheeseCake.Text);


            double latteT = latteN * latteP;
            double cappuccinoT = cappuccinoN * cappuccinoP;
            double americanoT = americanoN * americanoP;
            double espressoT = espressoN * espressoP;
            double mochaT = mochaN * mochaP;
            double macchiatoT = macchiatoN * macchiatoP;

            double butterCT = butterCN * butterCP;
            double poundCT = poundCN * poundCP;
            double spongeCT = spongeCN * spongeCP;
            double genoiseCT = genoiseCN * genoiseCP;
            double angelfoodCT = angelfoodCN * angelfoodCP;
            double cheeseCT = cheeseCN * cheeseCP;

            double result = latteT + cappuccinoT + americanoT + espressoT + mochaT + macchiatoT +
                            butterCT + poundCT + spongeCT + genoiseCT + angelfoodCT + cheeseCT + tax;

            return result;
        }

        private void checkBox_Latte_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Latte.Checked == true)
            {
                textBox_Latte.Enabled = true;
            }
            else
            {
                textBox_Latte.Enabled = false;
                textBox_Latte.Text = "0";
            }
        }

        private void checkBox_Cappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cappuccino.Checked == true)
            {
                textBox_Cappuccino.Enabled = true;
            }
            else
            {
                textBox_Cappuccino.Enabled = false;
                textBox_Cappuccino.Text = "0";
            }
        }

        private void checkBox_Americano_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Americano.Checked == true)
            {
                textBox_Americano.Enabled = true;
            }
            else
            {
                textBox_Americano.Enabled = false;
                textBox_Americano.Text = "0";
            }
        }

        private void checkBox_Espresso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Espresso.Checked == true)
            {
                textBox_Espresso.Enabled = true;
            }
            else
            {
                textBox_Espresso.Enabled = false;
                textBox_Espresso.Text = "0";
            }
        }

        private void checkBox_Mocha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Mocha.Checked == true)
            {
                textBox_Mocha.Enabled = true;
            }
            else
            {
                textBox_Mocha.Enabled = false;
                textBox_Mocha.Text = "0";
            }
        }

        private void checkBox_Macchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Macchiato.Checked == true)
            {
                textBox_Macchiato.Enabled = true;
            }
            else
            {
                textBox_Macchiato.Enabled = false;
                textBox_Macchiato.Text = "0";
            }
        }

        private void checkBox_ButterCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ButterCake.Checked == true)
            {
                textBox_ButterCake.Enabled = true;
            }
            else
            {
                textBox_ButterCake.Enabled = false;
                textBox_ButterCake.Text = "0";
            }
        }

        private void checkBox_PoundCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PoundCake.Checked == true)
            {
                textBox_PoundCake.Enabled = true;
            }
            else
            {
                textBox_PoundCake.Enabled = false;
                textBox_PoundCake.Text = "0";
            }
        }

        private void checkBox_SpongeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SpongeCake.Checked == true)
            {
                textBox__SpongeCake.Enabled = true;
            }
            else
            {
                textBox__SpongeCake.Enabled = false;
                textBox__SpongeCake.Text = "0";
            }
        }

        private void checkBox_GenoiseCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GenoiseCake.Checked == true)
            {
                textBox__GenoiseCake.Enabled = true;
            }
            else
            {
                textBox__GenoiseCake.Enabled = false;
                textBox__GenoiseCake.Text = "0";
            }
        }

        private void checkBox_AngelFoodCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AngelFoodCake.Checked == true)
            {
                textBox__AngelFoodCake.Enabled = true;
            }
            else
            {
                textBox__AngelFoodCake.Enabled = false;
                textBox__AngelFoodCake.Text = "0";
            }
        }

        private void checkBox_CheeseCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CheeseCake.Checked == true)
            {
                textBox__CheeseCake.Enabled = true;
            }
            else
            {
                textBox__CheeseCake.Enabled = false;
                textBox__CheeseCake.Text = "0";
            }
        }

        private void pb_ToLoginPage_Click(object sender, EventArgs e)
        {           
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
