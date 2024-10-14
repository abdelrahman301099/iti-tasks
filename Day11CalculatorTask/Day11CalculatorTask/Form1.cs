using System.Data;

namespace Day11CalculatorTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.AppendText("9");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox.AppendText("(");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.AppendText("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.AppendText(")");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.AppendText("+");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.AppendText("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.AppendText("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {


            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(textBox.Text, string.Empty);
                textBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }




        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }

}

