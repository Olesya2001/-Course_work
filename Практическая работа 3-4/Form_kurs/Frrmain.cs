using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Reflection;



namespace Form_kurs
{
    public partial class frmmain : Form
    {
        private int openDocuments = 0;
        public string CultureDefine;
        private string EnglishCulture;
        private string RussianCulture;
        public ResourceManager resourceManager;

        public frmmain()
        {
            // Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
            mnuSave.Enabled = false;
            //HelpProvider hp = new HelpProvider();
            EnglishCulture = "en-US";
            RussianCulture = "ru-RU";
            CultureDefine = CultureInfo.InstalledUICulture.ToString();
            resourceManager = new ResourceManager("_2._1.ClosingText", Assembly.GetExecutingAssembly());
        }

        public frmmain(string FormCulture)
        {
            InitializeComponent();
            EnglishCulture = "en-US";
            RussianCulture = "ru-RU";
            CultureDefine = FormCulture;
            resourceManager = new ResourceManager("_2._1.ClosingText", Assembly.GetExecutingAssembly());

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void Frrmain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild; frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild; frm.Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild; frm.Delete();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild; frm.SelectAll();
        }

        private void mnuOpen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            cmnuSaveAs.Enabled = true;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void mnuSave_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void Save(object sender, System.EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            saveFileDialog1.ShowDialog();
            frm.Save(saveFileDialog1.FileName);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            this.Save(frm.DocName, e);
        }
        public void mnuFile_Click(object sender, EventArgs e)
        {

        }

            public void cmnuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                cmnuSaveAs.Enabled = true;
                frm.IsSaved = true;
            }

        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { frm.richTextBox1.SelectionColor = colorDialog1.Color; }
            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            mnuNew_Click(this, new EventArgs());
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            mnuOpen_Click(this, new EventArgs());
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            mnuSave_Click(this, new EventArgs());
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            mnuCut_Click(this, new EventArgs());
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            mnuCopy_Click(this, new EventArgs());
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            mnuPaste_Click(this, new EventArgs());
        }

        private void Help_Click(object sender, EventArgs e)
        {
            
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Close();
             if (frm.IsSaved == true)
                  if (MessageBox.Show(resourceManager.GetString("MessageText"), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                      this.Save(frm.DocName, e);
        }

        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Eng_Click(object sender, EventArgs e)
        {
            CultureDefine = EnglishCulture;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false);
            frmmain frm = new frmmain(CultureDefine);
            this.Hide();
            frm.Show();
        }

        private void Rus_Click(object sender, EventArgs e)
        {
            CultureDefine = RussianCulture;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureDefine, false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureDefine, false);
            frmmain frm = new frmmain(CultureDefine);
            this.Hide();
            frm.Show();
        }

        private void Frrmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
