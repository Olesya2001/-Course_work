using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace График
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;
            try
            {
                x = System.Convert.ToDouble(this.textBox1.Text);
                label1.Visible = false;

                if (x < -3) y = 3;
                else if (x >= -3 && x <= 3) y = 3 - Math.Sqrt(9 - Math.Pow(x, 2));
                else if (x >= 3 && x <= 6) y = -2 * x + 9;
                else if (x >= 6) y = x - 9;

                this.label2.Text = System.Convert.ToString(Math.Round(y, 3));
            }
            catch
            {
                label1.Visible = true;
                this.label5.Text="Ошибка! Введено не число!";
                this.label2.Text = " ";
            }
            
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double y = 0;
            for (double x = -10; x < 20; x+=0.1)
            {
                if (x < -3) y = 3;
                else if (x >= -3 && x <= 3) y = 3 - Math.Sqrt(9 - Math.Pow(x, 2));
                else if (x >= 3 && x <= 6) y = -2 * x + 9;
                else if (x >= 6) y = x - 9;
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
