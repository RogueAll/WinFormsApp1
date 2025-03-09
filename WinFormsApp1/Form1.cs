using System.Drawing;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        bool first_num = true;
        int first = 0;
        int second = 0;
        string operacja = "";
        string label_temp = "";
        string temp = "";
        int out_put = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += " = ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!first_num) {
                label_temp = label1.Text;
                second = Int32.Parse(label_temp);
                switch (operacja) 
                {

                    case "+":
                        out_put =first+second;
                        temp = out_put.ToString();
                        label1.Text = temp;
                        break;
                    case "-":
                        out_put = first - second;
                        temp = out_put.ToString();
                        label1.Text = temp;
                        break;
                    case "*":
                        out_put = first * second;
                        temp = out_put.ToString();
                        label1.Text = temp;
                        break;
                    case "/":
                        out_put = first / second;
                        temp = out_put.ToString();
                        label1.Text = temp;
                        break;

                }
            }
        }

        

        private void button13_Click(object sender, EventArgs e)
        {
            operacja = "+";
            if (first_num) {
                label_temp = label1.Text;
                first = Int32.Parse(label_temp);
                operacja = "+";
                label1.Text = "";
                first_num = false;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            operacja = "/";
            if (first_num)
            {
                label_temp = label1.Text;
                first = Int32.Parse(label_temp);
                operacja = "/";
                label1.Text = "";
                first_num = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacja = "*";
            if (first_num)
            {
                label_temp = label1.Text;
                first = Int32.Parse(label_temp);
                operacja = "*";
                label1.Text = "";
                first_num = false;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            operacja = "-";
            if (first_num)
            {
                label_temp = label1.Text;
                first = Int32.Parse(label_temp);
                operacja = "-";
                label1.Text = "";
                first_num = false;
            }
        }
    }
}
