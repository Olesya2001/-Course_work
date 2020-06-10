using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Form1_Load(sender, e);
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 7; i++) //Создаем 7 строк 
            { 
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)//Заполняем таблицу рандомными значениями
            {

                for (int j = 0; j < 7; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(-10,25);
                }
            }
            dataGridView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("Сумма элементов по столбцам");
            int[] sum = new int[7];
            for (int i = 0; i < 7; i++)//Находим суммы по столбцам
            {
                for (int j = 0; j < 7; j++)
                {
                    sum[i] = sum[i] + Convert.ToInt32(dataGridView1[i, j].Value);
                }
            }
            Graphics gr = pictureBox1.CreateGraphics();

            gr.Clear(Color.White);
            Rectangle data_bounds = new Rectangle(0, 0, 10, 120);//Создаем диаграмму
            Point[] points = {
                new Point (0, pictureBox1.Height),
                new Point(pictureBox1.Width, pictureBox1.Height),
                new Point(0,0)
            };
            Pen myPen = new Pen(Color.Black, 1);
            gr.DrawLine(myPen, 0, 188, 280, 188);
            Matrix transformation = new Matrix(data_bounds, points);
            gr.Transform = transformation;

            using (Pen p = new Pen(Color.White, 0))//Выводим диаграмму , зависящую от суммы по столбцам
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    Rectangle rect = new Rectangle(i, 3, 1, sum[i]);
                    using (Brush br = new SolidBrush(Color.LightBlue))
                    {
                        gr.FillRectangle(br, rect);
                        gr.DrawRectangle(p, rect.X, rect.Y, rect.Width, rect.Height);
                    }
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
