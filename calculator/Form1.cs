using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义操作数
        float op1 = 0;
        float op2 = 0;
        double result = 0;

        //定义运算符号
        string symbol = null;

        //数字0-9
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "";
            }
            lblShow.Text += "0";
        }

        //运算符 + - * /
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "")
            {
                MessageBox.Show("输入有误", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "+";
                symbol = "+";
            }
            else{
                op1 = float.Parse(lblShow.Text);
                lblShow.Text = "+";
                symbol = "+";
            }
            

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "")
            {
                MessageBox.Show("输入有误", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "-";
                symbol = "-";
            }
            else{
                op1 = float.Parse(lblShow.Text);
                lblShow.Text = "-";
                symbol = "-";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "")
            {
                MessageBox.Show("输入有误", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "*";
                symbol = "*";
            }
            else{
                op1 = float.Parse(lblShow.Text);
                lblShow.Text = "*";
                symbol = "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "")
            {
                MessageBox.Show("输入有误", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "/";
                symbol = "/";
            }
            else{
                op1 = float.Parse(lblShow.Text);
                lblShow.Text = "/";
                symbol = "/";
            }
            
        }

        //小数点
        private void btnDot_Click(object sender, EventArgs e)
        {
            lblShow.Text += ".";
        }

        //=
        private void btnEqual_Click(object sender, EventArgs e)
        {
            op2 = float.Parse(lblShow.Text);
            switch(symbol){
                case "+":
                    result = op1 + op2;
                    symbol = "=";
                    break;
                case "-":
                    result = op1 - op2;
                    symbol = "=";
                    break;
                case "*":
                    result = op1 * op2;
                    symbol = "=";
                    break;
                case "/":
                    if (op2 == 0){
                        MessageBox.Show("除数不能为0！","计算错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        op2 = 1.0f;
                    }
                    result = op1 / op2;
                    symbol = "=";
                    break;
                case "^":
                    result = Math.Pow(op1,op2);;
                    symbol = "=";
                    break;
                case "log":
                    result = Math.Log10(op2); ;
                    symbol = "=";
                    break;
                case "sin":
                    result = Math.Sin(op2); ;
                    symbol = "=";
                    break;
                case "cos":
                    result = Math.Cos(op2); ;
                    symbol = "=";
                    break;
                case "tan":
                    result = Math.Tan(op2); ;
                    symbol = "=";
                    break;
                case "=":
                    symbol = "=";
                    break;
            }
            lblShow.Text = result.ToString();
          
        }

        //clear
        private void btnAC_Click(object sender, EventArgs e)
        {
            op1 = 0;
            op2 = 0;
            result = 0;
            lblShow.Text = "0";
        }

        //^ log sin cos tan
        private void btnex_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "")
            {
                MessageBox.Show("输入有误", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" ||lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "^";
                symbol = "^";
            }
            else
            {
                op1 = float.Parse(lblShow.Text);
                lblShow.Text = "^";
                symbol = "^";
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "log";
                symbol = "log";
            }
            else
            {
         
                lblShow.Text = "log";
                symbol = "log";
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "sin";
                symbol = "sin";
            }
            else
            {
                
                lblShow.Text = "sin";
                symbol = "sin";
            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "cos";
                symbol = "cos";
            }
            else
            {
               
                lblShow.Text = "cos";
                symbol = "cos";
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "+" || lblShow.Text == "-" || lblShow.Text == "*" || lblShow.Text == "/" || lblShow.Text == "^" || lblShow.Text == "log" || lblShow.Text == "sin" || lblShow.Text == "cos" || lblShow.Text == "tan")
            {
                lblShow.Text = "tan";
                symbol = "tan";
            }
            else
            {
               
                lblShow.Text = "tan";
                symbol = "tan";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }   
    }
}
