using System;
namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        public double firstValue;
        public double secondValue;
        public double final;
        public string opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            secondValue = Convert.ToDouble(previousText);
            if(opt=="+")
            {
                final = firstValue + secondValue;
            }
            else if (opt == "-") 
            {
                final = firstValue-secondValue; 
            }
            else if(opt=="X")
            {
                final = firstValue * secondValue;
            }
            else if(opt=="/")
            {
                final = firstValue / secondValue;
            }
            screenTextBox.Text = Convert.ToString(final);
            label.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "1";
            screenTextBox.Text = previousText;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "2";
            screenTextBox.Text = previousText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "3";
            screenTextBox.Text = previousText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "4";
            screenTextBox.Text = previousText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "5";
            screenTextBox.Text = previousText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "6";
            screenTextBox.Text = previousText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "7";
            screenTextBox.Text = previousText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "8";
            screenTextBox.Text = previousText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            previousText += "9";
            screenTextBox.Text = previousText;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            firstValue = Convert.ToDouble(previousText);
            previousText += "+";
            opt = "+";
            screenTextBox.Text = "";
            label.Text = previousText;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            firstValue = Convert.ToDouble(previousText);
            previousText += "-";
            opt = "-";
            screenTextBox.Text = "";
            label.Text = previousText;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            firstValue = Convert.ToDouble(previousText);
            previousText += "/";
            opt = "/";
            screenTextBox.Text = "";
            label.Text = previousText;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            firstValue = Convert.ToDouble(previousText);
            previousText += "X";
            opt = "X";
            screenTextBox.Text = "";
            label.Text = previousText;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            screenTextBox.Text = "";
            label.Text = "";
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            string previousText = screenTextBox.Text;
            string final = "";
            for(int i=0; i<previousText.Length; i++)
            {
                if(i!=previousText.Length-1)
                    final += previousText[i];
            }
            screenTextBox.Text = final; 
        }
    }
}