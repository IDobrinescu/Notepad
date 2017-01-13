using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
   public partial class FindForm : Form
   {
      private CustomTabControl _tabControl;
      private Form1 _form1;
      private Match _match;

      public FindForm(Form1 form1)
      {
         InitializeComponent();
         _tabControl = form1.tabControl;
         _form1 = form1;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         MyTabPage curenTabPage = (MyTabPage) _tabControl.SelectedTab;
         if (_match == null)
         {
            Regex regex = new Regex(findTextBox.Text, RegexOptions.IgnoreCase);
            _match = regex.Match(curenTabPage.MyPanel.TextBox1.Text);
            if (_match.Success)
            {
               curenTabPage.MyPanel.TextBox1.SelectionStart = _match.Index;
               curenTabPage.MyPanel.TextBox1.SelectionLength = _match.Length;
               _form1.Focus();
            }
            else
            {
               MessageBox.Show("Text not found");
            }
         }
         else
         {
            _match = _match.NextMatch();
            curenTabPage.MyPanel.TextBox1.SelectionStart = _match.Index;
            curenTabPage.MyPanel.TextBox1.SelectionLength = _match.Length;
            _form1.Focus();
         }
      }

      private void replaceButton_Click(object sender, EventArgs e)
      {
         MyTabPage curenTabPage = (MyTabPage)_tabControl.SelectedTab;
         Regex regex = new Regex(findTextBox.Text);
         string result = regex.Replace(curenTabPage.MyPanel.TextBox1.Text, replaceTextBox.Text, 1);
         if (result == String.Empty)
         {
            MessageBox.Show("Text not found");
         }
         else
         {
            curenTabPage.MyPanel.TextBox1.Text = result;
            _match = null;
         }
         
      }
   }
}
