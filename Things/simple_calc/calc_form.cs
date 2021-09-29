/*
 Dyson Smith
 Calculator
 Sept. 27 2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalc
{
    public partial class calc_form : Form
    {
        String output;
        int operand1;
        int operand2;
        String opp;
        public calc_form()
        {
            InitializeComponent();
        }

        private void calc_form_Load(object sender, EventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            opp = "";
            output = "0";
            output_txb.Text = output;
            //adding text to buttons
            button0.Text = "0";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7"; 
            button8.Text = "8";
            button9.Text = "9";
            addition_bttn.Text = "+";
            subtraction_bttn.Text = "-";
            multiply_bttn.Text = "*";
            divition_btttn.Text = "/";
            submit_bttn.Text = "=";
            clear_bttn.Text = "C";

            //set font properties
            Font font = new Font("Perpetua Titling MT", 28, FontStyle.Bold);
            button0.Font = font;
            button1.Font = font;
            button2.Font = font;
            button3.Font = font;
            button4.Font = font;
            button5.Font = font;
            button6.Font = font;
            button7.Font = font;
            button8.Font = font;
            button9.Font = font;
            addition_bttn.Font = font;
            subtraction_bttn.Font = font;
            multiply_bttn.Font = font;
            divition_btttn.Font = font;
            submit_bttn.Font = font;
            clear_bttn.Font = font;

            output_txb.Font = new Font("Perpetua Titling MT", 36);
        }

        private void button1_Click(object sender, EventArgs e)// makeing all the number buttons put their respective numbers on the screen

        {
            if (output == "0")
            {
                output = "1";
            }
            else
            {
                output = output + "1";
            }
            output_txb.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "2";
            }
            else
            {
                output = output + "2";
            }
            output_txb.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "3";
            }
            else
            {
                output = output + "3";
            }
            output_txb.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "4";
            }
            else
            {
                output = output + "4";
            }
            output_txb.Text = output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "5";
            }
            else
            {
                output = output + "5";
            }
            output_txb.Text = output;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "6";
            }
            else
            {
                output = output + "6";
            }
            output_txb.Text = output;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "7";
            }
            else
            {
                output = output + "7";
            }
            output_txb.Text = output;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "8";
            }
            else
            {
                output = output + "8";
            }
            output_txb.Text = output;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "9";
            }
            else
            {
                output = output + "9";
            }
            output_txb.Text = output;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (output == "0")
            {
                output = "0";
            }
            else
            {
                output = output + "0";
            }
            output_txb.Text = output;
        }

        private void addition_bttn_Click(object sender, EventArgs e)// makeing the opperater buttons function
        {
            if (output.Length >=10)
            {
                MessageBox.Show("Overflow error make a smaller number");
            }
            else
            {
                operand1 = int.Parse(output);
                opp = "+";
                output = "0";
                output_txb.Text = output;
            }
        }

        private void subtraction_bttn_Click(object sender, EventArgs e)
        {
            if (output.Length >=10)
            {
                MessageBox.Show("Overflow error make a smaller number");
            }
            else
            {
                operand1 = int.Parse(output);
                opp = "-";
                output = "0";
                output_txb.Text = output;
            }
        }

        private void multiply_bttn_Click(object sender, EventArgs e)
        {
            if (output.Length >=10)
            {
                MessageBox.Show("Overflow error make a smaller number");
            }
            else
            {
                operand1 = int.Parse(output);
                opp = "*";
                output = "0";
                output_txb.Text = output;
            }
        }

        private void divition_btttn_Click(object sender, EventArgs e)
        {
            if (output.Length >=10)
            {
                MessageBox.Show("Overflow error make a smaller number");
            }
            else
            {
                operand1 = int.Parse(output);
                opp = "/";
                output = "0";
                output_txb.Text = output;
            }
        }

        private void submit_bttn_Click(object sender, EventArgs e)
        {
            /* operand 1 opp opperand 2 = ans
            * get ans by using if and else if statments depending on the opperator
            * if opp == "+" 
            * {
            *  ans = operand1+opperand2
            *  }
            *  repeat above with all operaters
            * change ans to string
            * ans displayed on screen using variabl*/
            double ans;
            if (output.Length >= 10)
            {
                MessageBox.Show("Overflow error make a smaller number");
            }
            else
            {
                operand2 = int.Parse(output); 
            }
            if (opp == "+")
            {
                ans = operand1 + operand2;
            }
            else if (opp == "-")
            {
                ans = operand1 - operand2;
            }
            else if (opp == "*")
            {
                ans = operand1 * operand2;
            }
            else if (opp == "/")
            {
                ans = 0;
                if (operand2 == 0)
                {
                    MessageBox.Show("Don't divide by 0 dummie");
                }
                else
                {
                    ans = (double)operand1 / (double)operand2;
                }
            }
            else
            {
                ans = 0;
            }
            
            output = ans.ToString();
            output_txb.Text = output;
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            opp = "";
            output = "0";
            output_txb.Text = output;
        }
    }
}
