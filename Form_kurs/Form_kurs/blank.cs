using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace Form_kurs
{
    public partial class blank : Form
    {
        public blank()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText =
                Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        public string DocName = "";
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Amount of symbols " +
                richTextBox1.Text.Length.ToString();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e, CultureInfo с)
        {
            sbAmount.Text = "Количество символов " +
                richTextBox1.Text.Length.ToString();
        }
        public void Cut()
        {
            richTextBox1.Cut();
        }
        public void Copy()
        {
            richTextBox1.Copy();
        }
        public void Paste()
        {
            richTextBox1.Paste();
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        {
            richTextBox1.SelectedText="";
        }
        public void Open(string OpenFileName)
        {
            if(OpenFileName=="")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                DocName = OpenFileName;
            }
        }

        public void Save(string SaveFileName)
        {
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                IsSaved = true;
                sw.WriteLine(richTextBox1.Text);
                DocName = SaveFileName;
               
            }
        }
        public bool IsSaved = false;
        public string fileName;
        private void blank_Load(object sender, EventArgs e)
        {
            frmmain frmm = (frmmain)this.MdiParent;
            if (IsSaved == true)
                if (MessageBox.Show(frmm.resourceManager.GetString("MessageText"),
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    frmm.cmnuSaveAs_Click(DocName, e);
            if (IsSaved == true)
                if (MessageBox.Show("Do you want save changes in" + this.DocName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
        }

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == true)
                if (MessageBox.Show("Do you want save changes in" + this.DocName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
        }
    }
}
