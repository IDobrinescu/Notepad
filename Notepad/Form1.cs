using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                panel1.TextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                tabControl1.SelectedTab.Text = openFileDialog1.SafeFileName;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTabPage tabPage = (MyTabPage) tabControl1.SelectedTab;
            System.IO.File.WriteAllText(@"C:\Users\Ionut\Desktop\TP\Notepad\text.txt", tabPage.NewPanel.TextBox1.Text);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MyPanel panel = new MyPanel();
            MyTabPage tab = new MyTabPage(panel);
            tab.Controls.Add(panel);
            tab.Text = "New";
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            string line = "1";
            MyTabPage currentTab = (MyTabPage) tabControl1.SelectedTab;
            SyncTextBox textBox1 = currentTab.NewPanel.TextBox1;
            SyncTextBox textBox2 = currentTab.NewPanel.TextBox2;
            // if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back) {
            if (textBox1.Lines.Count() == 0)
            {
                textBox2.Text = "1";
            }
            for (int i = 2; i <= textBox1.Lines.Count(); i++)
            {
                line += Environment.NewLine + i.ToString();
            }
            if (!textBox2.Text.Equals(line))
            {
                textBox2.ResetText();
                textBox2.Text = line;
            }
            //move the cursor to the last line
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyTabPage tabPage = (MyTabPage) tabControl1.SelectedTab;
                System.IO.File.WriteAllText(@"C:\Users\Ionut\Desktop\TP\Notepad\text.txt",
                    tabPage.NewPanel.TextBox1.Text);
            }
        }
    }
}
