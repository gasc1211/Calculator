using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        public float cache = 0f;
        public char op;
        public float n1, n2;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void ActualOp(char operation)
        {
            if (Display.Text != "")
            {
                cache = float.Parse(Display.Text);
                Display_2.Text = cache.ToString()+operation;
                Display.Text = "";
                op = operation;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Display.AppendText("9");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Display.AppendText("8");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Display.AppendText("7");
        }

        private void six_Click(object sender, EventArgs e)
        {
            Display.AppendText("6");
        }

        private void five_Click(object sender, EventArgs e)
        {
            Display.AppendText("5");
        }

        private void four_Click(object sender, EventArgs e)
        {
            Display.AppendText("4");
        }

        private void three_Click(object sender, EventArgs e)
        {
            Display.AppendText("3");
        }

        private void two_Click(object sender, EventArgs e)
        {
            Display.AppendText("2");
        }

        private void one_Click(object sender, EventArgs e)
        {
            Display.AppendText("1");
        }

        private void d_zero_Click(object sender, EventArgs e)
        {
            Display.AppendText("00");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Display.AppendText("0");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Display.AppendText(".");
        }

        private void c_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Display_2.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (Display.Text != "")
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            ActualOp('+');
        }

        private void subs_Click(object sender, EventArgs e)
        {
            ActualOp('-');
        }

        private void mult_Click(object sender, EventArgs e)
        {
            ActualOp('x');
        }

        private void div_Click(object sender, EventArgs e)
        {
            ActualOp('÷');
        }

        private void ce_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            if (Display.Text != "" && Display_2.Text != "")
            {
                n1 = float.Parse(Display_2.Text.Substring(0, Display_2.TextLength - 1));
                n2 = float.Parse(Display.Text);

                switch (op)
                {
                    case '+':
                        Display.Text = (n1 + n2).ToString();
                        break;
                    case '-':
                        Display.Text = (n1 - n2).ToString();
                        break;
                    case 'x':
                        Display.Text = (n1 * n2).ToString();
                        break;
                    case '÷':
                        Display.Text = (n1 / n2).ToString();
                        break;
                }

                Display_2.Text = "";
            }
            
        }
    }
}
