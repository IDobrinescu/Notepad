using System;
using System.Linq;
using System.Windows.Forms;


namespace Notepad
{
   public partial class Form1 : Form
   {
      private Functions functions;
      internal CustomTabControl tabControl;

      public Form1()
      {
         InitializeComponent();
         tabControl = tabControl1;
         functions = new Functions(tabControl1);
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         functions.OpenFile();
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         functions.Save();
      }

      private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
      {
         functions.MakeNewTab();
      }

      private void tabControl1_KeyUp(object sender, KeyEventArgs e)
      {
         functions.LineNumber();
      }

      private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         functions.SaveAs();
      }

      private void findToolStripMenuItem_Click(object sender, EventArgs e)
      {
         functions.Find(this);
      }

      private void panel1_DragEnter(object sender, DragEventArgs e)
      {
         e.Effect = DragDropEffects.All;
      }

      private void panel1_DragDrop(object sender, DragEventArgs e)
      {
         MyTabPage tabPage = (MyTabPage) tabControl1.SelectedTab;
         string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
         if (files != null && files.Length != 0)
         {
            tabPage.MyPanel.TextBox1.Text = System.IO.File.ReadAllText(files[0]);
         }
         string[] path = files[0].Split('\\');
         tabPage.Text = path.Last();
      }
   }
}
