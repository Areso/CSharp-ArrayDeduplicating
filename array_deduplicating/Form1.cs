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
            int i, ii; //счетчики циклов
            int input_array_qty; //длина массива слов
            string input; //входящая строка
            //string[] input_array = new string[20]; //использовано в другой реализации заполнения массива слов
            //string backspace; //использовано в другой реализации заполнения массива слов
            textBox2.Text = ""; //очищаем поле вывода
        
            //init variables
            input = textBox1.Text;//"В недрах тундры выдры в гетрах тырят в вёдра ядра кедра";
            input = input.ToLower();
            //                       0   1       2      3  4   5      6   7  8     9    10
            //backspace = " ";//использовано в другой реализации заполнения массива слов
            i = 0;
            ii = 0;

            //string to array of words-читает массив задом наперед)
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
            
            string [] input_array = input.Split(new Char[] {' '}); // инициируем и заполняем массив слов из входящей строки

            input_array_qty = input_array.Length-1; //узнаем длину массива
                      
                  
            //ищем совпадения
            while (i <= input_array_qty)//каждое словое в строке
            {
                while (ii <= input_array_qty)//сравниваем с с каждым
                {
                    
                    if (input_array[i] == input_array[ii] && i!=ii) //если сравнимое слово равно тому, с которым сравниваем и это не слово в строке не имеет одну и ту же позицию, то
                    {
                        input_array[ii]="";//удаляем повторное значение из массива
                    }
                    ii = ii + 1;
                }
                ii = 0; //обнуляем счетчик вложенного цикла
                i = i + 1;
            }

           
            
            //удаляем пустые элементы путем замены на следующие не пустые
            i = 0;
            ii = 0;
            int tmp = 0;
            while (i <= input_array_qty)
            {
                if (input_array[i]=="")
                {
                    tmp = i;
                    while (i < input_array_qty)
                    {
                        input_array[i] = input_array[i + 1];
                        i = i + 1;
                    }
                    if (i == input_array_qty)
                    {
                        input_array[input_array_qty] = "";
                    }
                    i = tmp;
                }
                
                i = i + 1;
            }

            //выводим на экран результат
            i = 0;
            while (i <= input_array_qty)
            {
                textBox2.Text = textBox2.Text + input_array[i] + Environment.NewLine;
                i = i + 1;
            }
            
        }
    }
}
