using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace array_deduplicating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            int i, ii; //counters for cycles
            int input_array_qty; //length of input_array
            string input; //input string
            //string[] input_array = new string[20];
            string backspace;
            textBox2.Text = "";

            //init variables
            input = textBox1.Text;//"В недрах тундры выдры в гетрах тырят в вёдра ядра кедра";
            input = input.ToLower();
            //       0   1       2      3  4   5      6   7  8     9    10
            backspace = " ";
            i = 0;
            ii = 0;

            //string to array of words
            /*
            {
                while (input != "")
                {
                    if (input.LastIndexOf(backspace) == -1)
                    {
                        input_array[i] = input;
                        input = "";
                        break;
                    }
                    input_array[i] = input.Substring(input.LastIndexOf(backspace));
                    input = input.Remove(input.LastIndexOf(backspace));
                    i = i + 1;
                }
            }
            */
            string [] input_array = input.Split(new Char[] {' '}); // this will works only in C#

            //looking for equals
            input_array_qty = 10;
            MessageBox.Show(input_array[0]);
            MessageBox.Show(i.ToString());

            i = 0;
            int[,] match = new int[20, 20];
            /*
            while (ii <= input_array_qty)
            {
                if (input_array[0] == input_array[ii])
                {
                    MessageBox.Show(input_array[0] + " ; input array ii is " + ii + " : " + input_array[ii]);
                }
                ii = ii + 1;
            }
            */
            
            while (i <= input_array_qty)
            {
                while (ii <= input_array_qty)
                {
                    if (input_array[i] == input_array[ii])// && i!=ii)
                    {
                        match[i, ii] = 1;
                        MessageBox.Show("input array i is " + i + " : " + input_array[i] + " ; input array ii is " + ii + " : " + input_array[i]);
                    }
                    int local;
                    local = match[i, ii];
                    textBox2.Text = textBox2.Text + " "+ local.ToString();
                    //MessageBox.Show("ii is "+ii.ToString());
                    ii = ii + 1;
                }
                textBox2.Text = textBox2.Text + Environment.NewLine; //Char(13) + Char(10);
                ii = 0;
                //MessageBox.Show("i is " + i.ToString());
                i = i + 1;
            }
            
        }
    }
}
