namespace Calculator_Projrect_Tanzeel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        char sign;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(display.Text);
            sign = '+';
            display.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(display.Text);
            sign = '-';
            display.Text = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(display.Text);
            sign = '*';
            display.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(display.Text);
            sign = '/';
            display.Text = "";
        }
        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(display.Text);
            if (sign=='+')
            {
                result = num1 + num2;
                display.Text = result.ToString();
            }
            else if (sign == '-')
            {
                result = num1 - num2;
                display.Text = result.ToString();
            }
            else if (sign == '*')
            {
                result = num1 * num2;
                display.Text = result.ToString();
            }
           else if (sign == '/')
            {
                result = num1 / num2;
                display.Text = result.ToString();
            }
        }
    }
}
