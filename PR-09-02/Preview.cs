using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_09_02
{
    public partial class Preview : Form
    {
        // объект Image для хранения изображения
        Image ToView;
        // модифицируем конструктор окна таким образом, чтобы он получал
        // в качестве параметра изображение для отображения
        public Preview(Image view)
        {
            // получаем изображение
            ToView = view;
            InitializeComponent();
        }
        public Preview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // эта функция выполнится при загрузке окна
        private void Preview_Load(object sender, EventArgs e)
        {
            // если объект, хранящий изображение не равен
            if (ToView != null)
            {
                // устанавливаем новые размеры элемента pictureBox1,
                // равные ширине (ToView.Width) и высоте (ToView.Height) загружаемого изображения.
                pictureBox1.Size = new Size(ToView.Width, ToView.Height);
                // устанавливаем изображение для отображения в элементе pictureBox1
                pictureBox1.Image = ToView;
            }
        }
    }
}
