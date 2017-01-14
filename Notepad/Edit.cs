using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
   public class Edit
   {
      private Form1 _searchInFrm;
      private FindForm _searchForFrm;
      private Match _match;
      private MyTabPage curentTabPage = null;
      
      public Edit(Form1 searchInFrm, FindForm searchForFrm)
      {
         _searchInFrm = searchInFrm;
         _searchForFrm = searchForFrm;
      }

      public void SelectText()
      {
         if (_match != null)
         {
            if (_match.Success)
            {
               curentTabPage.MyPanel.TextBox1.SelectionStart = _match.Index;
               curentTabPage.MyPanel.TextBox1.SelectionLength = _match.Length;
               _searchInFrm.Focus();
            }
            else
            {
               MessageBox.Show("Text not found");
               _match = null;
            }
         }
      }

      public void Find()
      {
         if (_searchInFrm.tabControl.InvokeRequired)
         {
            _searchInFrm.tabControl.Invoke(new MethodInvoker(delegate { curentTabPage = (MyTabPage)_searchInFrm.tabControl.SelectedTab; }));
         }
         if (_match == null)
         {
            Regex regex = new Regex(_searchForFrm.FindTextBox.Text, RegexOptions.IgnoreCase);
            _match = regex.Match(curentTabPage.MyPanel.TextBox1.Text);
         }
         else
         {
            _match = _match.NextMatch();
            if (!_match.Success)
            {
               MessageBox.Show("End of file");
               _match = null;
            }
         }
      }

      public void Replace()
      {
         MyTabPage curenTabPage = (MyTabPage)_searchInFrm.tabControl.SelectedTab;
         Regex regex = new Regex(_searchForFrm.FindTextBox.Text);
         string result = regex.Replace(curenTabPage.MyPanel.TextBox1.Text, _searchForFrm.ReplaceTextBox.Text, 1);
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
