using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double d = ((2 * Convert.ToInt32(textBox1.Text) - 7) / (Math.Sqrt(3 * Convert.ToInt32(textBox1.Text) + 21)));
            label1.Text = Convert.ToString(d);

            double d1 = (Math.Sqrt(Convert.ToInt32(textBox1.Text) / (Convert.ToInt32(textBox1.Text) - 1)));
            label2.Text = Convert.ToString(d1);

            double d2 = ((Convert.ToInt32(textBox1.Text) + 1) / (Convert.ToInt32(textBox1.Text) - 1) + Math.Sqrt(Math.Pow(Convert.ToInt32(textBox1.Text), 2)));
            label3.Text = Convert.ToString(d2);
        }
    }
}
