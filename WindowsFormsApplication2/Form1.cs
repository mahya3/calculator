using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool plus=false, minus=false, equals=false, tagsim=false, zarb = false;
        double result1, result2;

        private void button18_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            minus = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            zarb = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            tagsim = false;
            zarb=false;
            plus = false;
            minus = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
            }
            catch(Exception)
            {
                textBox1.Text = "0";
            }
        }

        private void numbers(object sender, EventArgs e)
        {
            if(textBox1.Text!="0")
            {
                textBox1.Text += ((Button)sender).Text.ToString();
            }
            else
            {
                textBox1.Text = ((Button)sender).Text.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (minus == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double myresult = result1 - result2;
                textBox1.Text = myresult.ToString();
                minus = false;
            }
            else if (plus == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double myresult = result1 + result2;
                textBox1.Text = myresult.ToString();
                plus = false;
                
            }
            else if (zarb == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double myresult = result1 * result2;
                textBox1.Text = myresult.ToString();
                zarb = false;

            }
            else if (tagsim == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double myresult = result1 / result2;
                textBox1.Text = myresult.ToString();
                tagsim = false;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            plus = true;
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            tagsim = true;
        }
    }
}
