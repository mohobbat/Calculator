using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAPP
{
    public partial class CalcualtorAppUI : Form
    {
        public CalcualtorAppUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator=new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {

            aCalculator.firstNo = Convert.ToDouble(firstNoTextBox.Text);
            aCalculator.secondNo = Convert.ToDouble(secondNoTextBox.Text);
            resutTextBox.Text = Convert.ToString(aCalculator.Add());
            
            //MessageBox.Show(aCalculator.Add().ToString());
        }

        private void subtracButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNo = Convert.ToDouble(firstNoTextBox.Text);
            aCalculator.secondNo = Convert.ToDouble(secondNoTextBox.Text);
            resutTextBox.Text = Convert.ToString(aCalculator.Subtract());
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNo = Convert.ToDouble(firstNoTextBox.Text);
            aCalculator.secondNo = Convert.ToDouble(secondNoTextBox.Text);
            resutTextBox.Text = Convert.ToString(aCalculator.multiply());
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNo = Convert.ToDouble(firstNoTextBox.Text);
            aCalculator.secondNo = Convert.ToDouble(secondNoTextBox.Text);
            resutTextBox.Text = Convert.ToString(aCalculator.Divided());
        }
    }
}
