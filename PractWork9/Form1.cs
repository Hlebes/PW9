using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(ball.ClientRectangle);
            ball.Region = new Region(path);

            int X = 10; // кол-во полей по горизонтали
            int Y = 4; // кол-во полей по вертикали
            int blockSizeX = 78; // устанавливаем размер полей
            int blockSizeY = 25; // устанавливаем размер полей
            for (int x = 1; x <= X; x++) // цикл по столбцам
            {
                for (int y = 1; y <= Y; y++) // цикл по строкам
                {
                    Panel block = new Panel(); // создаём новое поле
                    block.Width = blockSizeX; // устанавливаем ширину
                    block.Height = blockSizeY; // устанавливаем высоту
                    block.Location = new Point(x * blockSizeX - 50, y * blockSizeY + 20); // перемещаем поле на нужное место
                    block.BorderStyle = BorderStyle.FixedSingle; // устанавливаем стиль границы обрамления
                    this.Controls.Add(block); // добавление поля в коллекцию элементов управления
                }
            }
        }
    }
}
