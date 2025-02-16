using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clas;

namespace Calc
{

    public partial class Калькулятор : Form
    {
        char znak;
        public Калькулятор()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        void nul(object sender)
        {
            if(textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно")
            textBox1.Text += (sender as Button).Text;
        }
        void enable()
        {
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button20.Enabled = true;
            button19.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button16.Enabled = true;
            button18.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nul(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно" && textBox1.Text.Length >0)
            {
                a = Convert.ToDouble(textBox1.Text);
                a = 1 / a;
                if (a != 0)
                {
                    textBox1.Text = a.ToString();
                }
                else
                {
                    textBox1.Text = "Деление на ноль невозможно";
                }
            }
            
            
        }
        double a = 0, b = 0, c = 0;

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            c= 0;
            enable();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно" )
                    textBox1.Text += (sender as Button).Text;
                s = 1;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно" && textBox1.Text != "")
            {
                if (a == 0)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    a = a * (-1);
                    textBox1.Text = a.ToString();
                }
                else
                {
                    b = Convert.ToDouble(textBox1.Text);
                    b = b * (-1);
                    textBox1.Text = b.ToString();
                }
                
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = "Введите число";
                enable();
            }


        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = "Введите число";
                enable();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = "Введите число";
                enable();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = "Введите число";
                enable();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно" && textBox1.Text.Length > 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                a = a * a;
                textBox1.Text = a.ToString();
            }
                
        }
        int s = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "Введите число" && textBox1.Text != "Деление на ноль невозможно" && textBox1.Text.Length > 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                a = Math.Sqrt(a);
                textBox1.Text = a.ToString();
            }
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = "Введите число";
                enable();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double d , e;
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Деление на ноль невозможно" && textBox1.Text != "Введите число" && textBox1.Text != "не число")
            {
                if (textBox1.Text.Length > 0)
                {
                    b = Convert.ToDouble(textBox1.Text);
                    switch (znak)
                    {
                    case '+':
                        c = Calc_class.sum(a, b);
                        //c = a + b;
                        textBox1.Text = c.ToString();
                        break;
                    case '-':
                        c = Calc_class.sub(a, b);
                        textBox1.Text = c.ToString();
                        break;
                    case '/':
                        if (b == 0)
                        {
                            textBox1.Text = "Деление на ноль невозможно";
                            enable();
                        }
                        else
                        {
                            c = Calc_class.div(a, b);
                            textBox1.Text = c.ToString();
                        }
                        break;
                    case '*':
                        c = Calc_class.mul(a, b);
                        textBox1.Text = c.ToString();
                        break;
                    case '%':
                        c = a / 100 * b;
                        textBox1.Text = c.ToString();
                        break;
                    }
                }
                else
                {
                    textBox1.Text = "Введите число";
                }
            }
            else
            {
                textBox1.Clear();
                enable();
            }  
        }
        
    }
}
            
