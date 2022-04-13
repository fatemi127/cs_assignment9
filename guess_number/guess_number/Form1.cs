using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_number
{
    public partial class Form1 : Form
    {
        Random r;
        int computer_number;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            computer_number = r.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_number = Convert.ToInt32(textBox1.Text);
            if (user_number == computer_number)
            {
                label1.Text = "شما برنده شدی";
            }
            else if (user_number > computer_number)
            {
                label1.Text = "برو پایین";
            }
            else if (user_number <computer_number)
            {
                label1.Text = "برو بالا";
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
