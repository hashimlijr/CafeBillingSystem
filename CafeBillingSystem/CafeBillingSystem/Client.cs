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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("DatasOfClients.txt");
            
            sw.WriteLine(textBox_Name.Text);

            this.Hide();           
        }
    }
}
