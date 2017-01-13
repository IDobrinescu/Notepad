using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      private void findToolStripMenuItem_Click( object sender, EventArgs e )
      {
         functions.Find(this);
      }
   }
}
