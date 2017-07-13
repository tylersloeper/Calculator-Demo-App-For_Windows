using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        public double currentValue = 0;
        public double previousValue = 0;
        public string CurrentOperation = "";
        public string PreviousOperation = "";

        public Form1()
        {
            InitializeComponent();
        }



        private void Number_Pressed(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Clear();
            }
            if(result.Text == currentValue.ToString())
            {
                result.Clear();
            }
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }


        private void Operator_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            currentValue = double.Parse(result.Text);

            if (b.Text == "+")
            {
                if (previousValue != 0 && PreviousOperation != "")
                {
                    if (PreviousOperation == "+")
                    {
                        currentValue = previousValue + currentValue;
                        result.Text = (currentValue).ToString();
                    }

                    previousValue = currentValue;
                    PreviousOperation = "+";
                }
                else
                {
                    previousValue = currentValue;
                    result.Text = "0";
                    PreviousOperation = "+";
                }
            }

            //0,1 +             0,1 + 
            //pv =0, cv =1;     pv=1

            if (b.Text == "-")
            {
                if (previousValue != 0 && PreviousOperation != "")
                {
                    if (PreviousOperation == "-")
                    {
                        currentValue = previousValue - currentValue;
                        result.Text = (currentValue).ToString();
                    }

                    previousValue = currentValue;
                    PreviousOperation = "-";
                }
                else
                {
                    previousValue = currentValue;
                    result.Text = "0";
                    PreviousOperation = "-";
                }
            }

            if (b.Text == "/")
            {
                if(previousValue != 0 && PreviousOperation != "")
                {
                    if (PreviousOperation == "/")
                    {
                        currentValue = previousValue / currentValue;
                        result.Text = (currentValue).ToString();
                    }

                    previousValue = currentValue;
                    PreviousOperation = "/";
                }
                else
                {
                    previousValue = currentValue;
                    result.Text = "0";
                    PreviousOperation = "/";
                }                
            }

            if (b.Text == "x")
            {
                if (previousValue != 0 && PreviousOperation != "")
                {
                    if (PreviousOperation == "x")
                    {
                        currentValue = previousValue * currentValue;
                        result.Text = (currentValue).ToString();
                    }
                    
                    previousValue = currentValue;
                    PreviousOperation = "x";

                }
                else
                {
                    previousValue = currentValue;
                    result.Text = "0";
                    PreviousOperation = "x";
                }
            }
 
            if (b.Text == "=")
            {
                if(PreviousOperation == "+")
                {
                    result.Text = (currentValue + previousValue).ToString();
                }
                if (PreviousOperation == "-")
                {
                    result.Text = (currentValue - previousValue).ToString();
                }
                if (PreviousOperation == "/")
                {
                    result.Text = (currentValue / previousValue).ToString();
                }
                if (PreviousOperation == "x")
                {
                    result.Text = (currentValue * previousValue).ToString();
                }
            }

            if (b.Text == "CE")
            {
                result.Text = "0";
            }
            if (b.Text == "C")
            {
                currentValue = 0;
                previousValue = 0;
                CurrentOperation = "";
                PreviousOperation = "";
                result.Text = "0";
            }
        }

 
    }
}
