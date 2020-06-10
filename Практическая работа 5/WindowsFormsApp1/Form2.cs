using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ratingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ratingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Rating". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.database1DataSet1.Rating);
            this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
            this.ratingTableAdapter.Fill(this.database1DataSet1.Rating);
            this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
            this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
            this.ratingTableAdapter.Fill(this.database1DataSet1.Rating);
            this.studentsTableAdapter.Fill(this.database1DataSet1.Students);
            this.ratingTableAdapter.Fill(this.database1DataSet1.Rating);
            this.ratingTableAdapter.Fill(this.database1DataSet1.Rating);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
        }

        private void FillBy1toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ratingTableAdapter.FillBy(this.database1DataSet1.Rating, groupToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
