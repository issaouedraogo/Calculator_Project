using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1 = 0;
        double number2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEqua_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtFirstNumbe.Text, out number1)&&double.TryParse(txtSecondNum.Text, out number2))
            {
                lblSolution.Text = (number1 + number2).ToString();
                lblOperator.Text = "+";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFirstNumbe.Text, out number1) && double.TryParse(txtSecondNum.Text, out number2))
            {
                lblSolution.Text = (number1 - number2).ToString();
                lblOperator.Text = "-";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumbe.Clear();
            txtSecondNum.Clear();
            lblOperator.Text = "";
            lblSolution.Text = "";  
        }

        private void btnExi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtFirstNumbe.Text, out number1) && double.TryParse(txtSecondNum.Text, out number2))
            {

                lblSolution.Text = (number1 * number2).ToString();
                lblOperator.Text = "*";
            }
        }

        private void btnPers_Click(object sender, EventArgs e)
        {
            //if(double.TryParse(txtFirstNumbe.Text, out number1) && double.TryParse(txtSecondNum.Text, out number2))
            //{
            //    lblSolution.Text = (number1  number2).ToString();
            //    lblOperator.Text = "*";
            //}
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtFirstNumbe.Text, out number1) && double.TryParse(txtSecondNum.Text, out number2))
            {
                lblSolution.Text = (number1 / number2).ToString();
                lblSolution.Text = "/";
            }
        }
    }
}
