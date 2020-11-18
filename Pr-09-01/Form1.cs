﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_09_01
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            // ппереводим координату X в строку и записывает в поля ввода
            textBox1.Text = e.X.ToString();
            // переводим координату Y в строку и записывает в поля ввода
            textBox2.Text = e.Y.ToString();
            Point tmp_location;
            Random rnd = new Random();
            textBox3.Text = button1.Location.X.ToString();
            textBox4.Text = button1.Location.Y.ToString();
            textBox5.Text = button1.Width.ToString();
            textBox6.Text = button1.Height.ToString();
            // если координата по оси X и по оси Y лежит в очерчиваемом вокруг кнопки "да, конечно" квадрате
            if (e.X >= button1.Location.X-1 && e.X <= (button1.Location.X+button1.Width) && e.Y >= button1.Location.Y-1 && e.Y <= (button1.Location.Y+button1.Height))
            {
               
                int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
                int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

                // запоминаем текущее положение окна
                tmp_location = this.Location;
                // генерируем перемещения по осям X и Y и прибавляем их к хранимому значению текущего положения окна
                // числа генерируются в диапазоне от -100 до 100
                 tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);
                // если окно вылезло за пределы экрана по одной из осей
                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) ||
                tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                { // новыми координатами станет центр окна
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }
                this.Location = tmp_location;
            }
        }
                private void button1_Click(object sender, EventArgs e)
        {
            // Вывести сообщение с текстом "Вы усердны"
            MessageBox.Show("Вы усердны!!");
            // Завершить приложение
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Вывести сообщение, с текстом "Мы не сомневались в вешем безразличии"
            // второй параметр - заголовок окна сообщения "Внимание"
            // MessageBoxButtons.OK - тип размещаемой кнопки на форме сообщения
            // MessageBoxIcon.Information - тип сообщения - будет иметь иконку "информация" и соответствующий звуковой сигнал
            MessageBox.Show("Мы не сомневались в вешем безразличии", "Внимание",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
