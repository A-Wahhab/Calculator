using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_Calculator
{
    public partial class MyCalculator : Form
    {
        bool isFirst = true;
        double N1, N2, temp = 0;
        char opr;
        public MyCalculator()
        {
            InitializeComponent();
        }
        private void One_Click(object sender, EventArgs e)
        {
            if(isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += One.Text;
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Two.Text;
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Three.Text;
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Four.Text;
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Five.Text;
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Six.Text;
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Seven.Text;
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Eight.Text;
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += Nine.Text;
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                return;
            }
            Screen.Text += Zero.Text;
        }
        private void DoubleZero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                return;
            }
            Screen.Text += DoubleZero.Text;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            isFirst = true;
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            N2 = Double.Parse(Screen.Text);
            double res = 0, r = ((3.141 / 180) * N2);
            switch(opr)
            {
                case '+':
                    res = N1 + N2;
                    break;
                case '-':
                    res = N1 - N2;
                    break;
                case '*':
                    res = N1 * N2;
                    break;
                case '/':
                    res = N1 / N2;
                    break;
                case 's':
                    res = Math.Sin(r);
                    isFirst = true;
                    break;
                case 'c':
                    res = Math.Cos(r);
                    isFirst = true;
                    break;
                case 't':
                    res = Math.Tan(r);
                    isFirst = true;
                    break;
                default:
                    isFirst = true;
                    return;
            }
            Screen.Text = res.ToString();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            opr = '-';
            isFirst = true;
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            opr = '*';
            isFirst = true;
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            opr = '/';
            isFirst = true;
        }
        private void Square_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            double t = N1 * N1;
            Screen.Text = t.ToString();
        }
        private void M_Clear_Click(object sender, EventArgs e)
        {
            temp = 0;
        }
        private void M_Recall_Click(object sender, EventArgs e)
        {
            Screen.Text = temp.ToString();
        }
        private void M_add_Click(object sender, EventArgs e)
        {
            temp += Double.Parse(Screen.Text);
        }
        private void M_Sub_Click(object sender, EventArgs e)
        {
            temp -= Double.Parse(Screen.Text);
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            int t = Int32.Parse(Screen.Text);
            t /= 10;
            Screen.Text = t.ToString();
            if (t == 0)
                isFirst = true;
        }
        private void Toggle_Click(object sender, EventArgs e)
        {
            double t = Double.Parse(Screen.Text);
            t *= -1;
            Screen.Text = t.ToString();
        }
        private void Sin_Click(object sender, EventArgs e)
        {
            Screen.Text = "sin ";
            opr = 's';
        }
        private void Cos_Click(object sender, EventArgs e)
        {
            Screen.Text = "cos ";
            opr = 'c';
        }
        private void Tan_Click(object sender, EventArgs e)
        {
            Screen.Text = "tan ";
            opr = 't';
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            double t = Math.Sqrt(N1);
            Screen.Text = t.ToString();
        }
        private void M_Store_Click(object sender, EventArgs e)
        {
            temp = Double.Parse(Screen.Text);
            isFirst = true;
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            N1 = Double.Parse(Screen.Text);
            opr = '+';
            isFirst = true;
        }
    }
}
