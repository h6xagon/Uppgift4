using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Istället för att slumpa unicode så slumpar vi en karaktär från
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string ans = "";
            int length;
            bool TryParseResult = int.TryParse(textBox1.Text, out length);
            for (int i = 0; i < length; i++)
            {
                int unicode = r.Next(33, 126);
                char c = (char)unicode;
                ans = ans + c.ToString();
            }
            label1.Text = ans;
        }

    }
}
