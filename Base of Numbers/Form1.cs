using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Base_of_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBX_Input.Text, out int i))
            {
                if (CBX_Base.Text == "2")
                {
                    TBX_Output.Text = binary(i);
                }
                if (CBX_Base.Text == "8")
                {
                    TBX_Output.Text = octal(i);
                }
                if (CBX_Base.Text == "16")
                {
                    TBX_Output.Text = hexadecimal(i);
                }
            }
        }
        string binary(int input)
        {
            string output = "";
            if (input - 128 >= 0)
            {
                output = "1" + output;
                input -= 128;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 64 >= 0)
            {
                output = "1" + output;
                input -= 64;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 32 >= 0)
            {
                output = "1" + output;
                input -= 32;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 16 >= 0)
            {
                output = "1" + output;
                input -= 16;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 8 >= 0)
            {
                output = "1" + output;
                input -= 8;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 4 >= 0)
            {
                output = "1" + output;
                input -= 4;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 2 >= 0)
            {
                output = "1" + output;
                input -= 2;
            }
            else
            {
                output = "0" + output;
            }
            if (input - 1 >= 0)
            {
                output = "1" + output;
            }
            else
            {
                output = "0" + output;
            }
            return output;
        }
        string octal(int input)
        {
            int eight = 8;
            string output = "";
            if (input / (eight*eight) >= 1)
            {
                output += input / (eight * eight);
                input -= (input / (eight * eight)) * eight * eight;
            }
            else
            {
                output = "0" + output;
            }
            if (input / eight >= 1)
            {
                output += input / eight;
                input -= (input / eight) * eight;
            }
            else
            {
                output = output + "0";
            }
            if (input >= 1)
            {
                output += input;
            }
            else
            {
                output = output + "0";
            }
            return output;
        }
        string hexadecimal(int input)
        {
            return input.ToString("X");
        }
    }
}