using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Giles_Lab3
{
    public partial class CalculatorForm : Form
    {
        string tbField = "";
        string valueA;
        string valueB;
        string math;

        Calculator doMath;
        public CalculatorForm()
        {
            InitializeComponent();
            doMath = new Calculator();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
          
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            tbField += 0;
            UpdateTbField(); 
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            tbField += 1;
            UpdateTbField();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbField += 2;
            UpdateTbField();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbField += 3;
            UpdateTbField();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbField += 4;
            UpdateTbField();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbField += 5;
            UpdateTbField();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbField += 6;
            UpdateTbField();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbField += 7;
            UpdateTbField();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbField += 8;
            UpdateTbField();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbField += 9;
            UpdateTbField();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            tbField += ".";
            UpdateTbField();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                tbOutput.Text = tbField.Remove(tbField.Length - 1, 1);
                tbField = tbOutput.Text;
            }
            catch (ArgumentOutOfRangeException)
            {
                //if textbox is empty or entry in textbox is not user-entered
                //do nothing but don't break
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTbField();
            valueA = "";
            math = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            SetValueA();
            valueB = "-1";
            math = "multiply";
            tbOutput.Text = Calculator.DoMath(valueA, valueB, math);

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetValueA();
            ClearTbField();
            math = "divide";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetValueA();
            ClearTbField();
            math = "multiply";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetValueA();
            ClearTbField();
            math = "subtract";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetValueA();
            ClearTbField();
            math = "add";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            valueB = tbField;
            ClearTbField();
            tbOutput.Text = Calculator.DoMath(valueA, valueB, math);
            SetValueA();
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            SetValueA();
            SetValueB();
            math = "sqrt";
            tbOutput.Text = Calculator.DoMath(valueA, valueB, math);
            SetValueA(); 
        }
        private void btn1x_Click(object sender, EventArgs e)
        {
            valueA = "1";
            SetValueB();
            math = "divide";
            tbOutput.Text = Calculator.DoMath(valueA, valueB, math);
            SetValueA();
        }

        public void SetValueA()
        {
            valueA = tbOutput.Text;
        }

        public void SetValueB()
        {
            valueB = tbOutput.Text;
        }

        public void UpdateTbField()
        {
            tbOutput.Text = tbField;
        }

        public void ClearTbField()
        {
            tbField = "";
            UpdateTbField();
        }

        public void ClearValueA()
        {
            valueA = "";
        }
        public void ClearValueB()
        {
            valueB = "";
        }

        public void ClearMath()
        {
            math = "";
        }
    }
    
}
