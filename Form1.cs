using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c3
{
    public partial class Form1 : Form
    {
        private char _math;
        private bool _clean;
        private int _num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text=="0")
            {
                label1.Text = " ";
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                label1.Text = "";
                _clean = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            label1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _math = '+';
            _clean = true;
            _num1 = Convert.ToInt32(label1.Text) ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(label1.Text);
            int result;
            switch (_math)
            {
                case '+':
                    result = _num1 + num2;
                    break;
                case '-':
                    result = _num1 - num2;
                    break;
                case '*':
                    result = _num1 * num2;
                    break;
                case '/':
                    result = _num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            label1.Text = Convert.ToString(result);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _math = '/';
            _clean = true;
            _num1 = Convert.ToInt32(label1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _math = '*';
            _clean = true;
            _num1 = Convert.ToInt32(label1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _math = '-';
            _clean = true;
            _num1 = Convert.ToInt32(label1.Text);
        }
    }
}
