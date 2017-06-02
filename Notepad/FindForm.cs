using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
   public partial class FindForm : Form
   {
      private Edit editor;
      public TextBox FindTextBox { get { return findTextBox; } set { findTextBox = value; } }
      public TextBox ReplaceTextBox { get { return replaceTextBox; } set { replaceTextBox = value; } }
      public FindForm(Form1 form1)
      {
         InitializeComponent();
         editor = new Edit(form1, this);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         backgroundWorker1.RunWorkerAsync();
      }

      private void replaceButton_Click(object sender, EventArgs e)
      {
        editor.Replace();
      }

      private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
      {
         editor.Find();
      }

      private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         editor.SelectText();
      }


      private void findTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            backgroundWorker1.RunWorkerAsync();
         }
      }

      private void replaceTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            editor.Replace();
         }
      }
   }
}
