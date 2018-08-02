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
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            View();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txt_Result.Text == "0") || (isOperationPerformed))
                txt_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!txt_Result.Text.Contains("."))
                {
                    txt_Result.Text = txt_Result.Text + button.Text;
                    if (resultValue != 0)
                        labelShow();
                }     
            }
            else
            {
                txt_Result.Text = txt_Result.Text + button.Text;
                if(resultValue != 0)
                    labelShow();
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                button_equal.PerformClick();
                operationPerformed = button.Text;
                lblShowOp.Text = resultValue + "" + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txt_Result.Text);
                lblShowOp.Text = resultValue + "" + operationPerformed;
                isOperationPerformed = true;
            }
        }

        public void labelShow()
        {
            lblShowOp.Text = resultValue + "" + operationPerformed + "" + txt_Result.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "0";
            resultValue = 0;
            lblShowOp.Text = "";
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txt_Result.Text = (resultValue + Double.Parse(txt_Result.Text)).ToString();
                    break;
                case "-":
                    txt_Result.Text = (resultValue - Double.Parse(txt_Result.Text)).ToString();
                    break;
                case "*":
                    txt_Result.Text = (resultValue * Double.Parse(txt_Result.Text)).ToString();
                    break;
                case "/":
                    txt_Result.Text = (resultValue / Double.Parse(txt_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txt_Result.Text);
            lblShowOp.Text = "";
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View();
        }

        public void View()
        {
            this.Width = 270;
            txt_Result.Width = 244;
        }

        private void scientficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            this.Width = 342;
            txt_Result.Width = 316;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txt_Result.Text);
            lblShowOp.Text = Convert.ToString("sin" + "(" + (txt_Result.Text) + ")");
            qSin = Math.Sin(qSin);
            txt_Result.Text = Convert.ToString(qSin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(txt_Result.Text);
            lblShowOp.Text = Convert.ToString("cos" + "(" + (txt_Result.Text) + ")");
            qCos = Math.Cos(qCos);
            txt_Result.Text = Convert.ToString(qCos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txt_Result.Text);
            lblShowOp.Text = Convert.ToString("tan" + "(" + (txt_Result.Text) + ")");
            qTan = Math.Tan(qTan);
            txt_Result.Text = Convert.ToString(qTan);
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            this.Width = 342;
            txt_Result.Width = 316;
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
            {
                operationPerformed = "*";
                lblShowOp.Visible = false;
                resultValue = Double.Parse(txt_Result.Text);
                isOperationPerformed = true;
            }
            else if(txt_Result.Text == "1")
            {
                operationPerformed = "*";
                lblShowOp.Visible = false;
                resultValue = Double.Parse(txt_Result.Text);
                isOperationPerformed = true;
            }
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "0")
            {
                operationPerformed = "+";
                lblShowOp.Visible = false;
                resultValue = Double.Parse(txt_Result.Text);
                isOperationPerformed = true;
            }
            else if (txt_Result.Text == "1")
            {
                operationPerformed = "+";
                lblShowOp.Visible = false;
                resultValue = Double.Parse(txt_Result.Text);
                isOperationPerformed = true;
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            if(txt_Result.Text == "0")
            {
                txt_Result.Text = "1";
            }
            else if(txt_Result.Text == "1")
            {
                txt_Result.Text = "0";
            }
        }
    }
}
