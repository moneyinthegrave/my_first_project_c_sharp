using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // получаем две строки из текстбокса
            string frist_num = textBox1.Text;
            string second_num = textBox2.Text;
            
            // создаем переменные для заполнения и создания массива
            int Start_of_array = Convert.ToInt32(frist_num);
            int end_of_array = Convert.ToInt32(second_num);
            
            // interval_length размерность массива
            int interval_length = (end_of_array - Start_of_array) + 1;
            
            int sum = 0;
            
            //создаем динаимческий массив
            int [] Array = new int [interval_length];
            
            // заполняем массив
            for (int i = 0; i < interval_length  ; i++)
            {
                Array[i] = Start_of_array;
                Start_of_array += 1;
            }
            // складываем элементы массива в переменную sum
            for (int i = 0; i < interval_length ; i++)
            {
                sum += Array[i];
            }
            // вывод в лейбл
            label1.Text = Convert.ToString(sum);
        }
    }
}