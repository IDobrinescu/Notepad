using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Notepad
{
   class Functions
   {
      private CustomTabControl tabControl1;
      private MyTabPage _selectedTabPage;

      public Functions(CustomTabControl tabControl1, string userName)
      {
         this.tabControl1 = tabControl1;
         _selectedTabPage = (MyTabPage) tabControl1.SelectedTab;
         _selectedTabPage.Document.UserName = userName;
      }

      public void SaveToDB(Form1 form1)
      {
         
      }

      public void Save()
      {
         //MyTabPage tabPage = (MyTabPage) tabControl1.SelectedTab;
         if (_selectedTabPage.Document.FilePath != null)
         {
            System.IO.File.WriteAllText(_selectedTabPage.Document.FilePath, _selectedTabPage.MyPanel.TextBox1.Text);
            _selectedTabPage.Document.FileText = _selectedTabPage.MyPanel.TextBox1.Text;
         }
         else
         {
            SaveAs();
         }
      }

      public void MakeNewTab()
      {
         MyPanel panel = new MyPanel();
         MyTabPage tab = new MyTabPage( panel );
         tab.Document.UserName = (tabControl1.SelectedTab as MyTabPage).Document.UserName;
         tab.Controls.Add( panel );
         tab.Text = "New";
         tabControl1.TabPages.Add( tab );
         tabControl1.SelectedTab = tab;
      }

      public void OpenFile()
      {
         // Create an instance of the open file dialog box.
         OpenFileDialog openFileDialog1 = new OpenFileDialog();

         // Set filter options and filter index.
         openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
         openFileDialog1.FilterIndex = 1;

         openFileDialog1.Multiselect = true;


         // Process input if the user clicked OK.
         if ( openFileDialog1.ShowDialog() == DialogResult.OK ) {
            // Open the selected file to read.

            _selectedTabPage.Document.FilePath = openFileDialog1.FileName;

            _selectedTabPage.MyPanel.TextBox1.Text = System.IO.File.ReadAllText( openFileDialog1.FileName );
            _selectedTabPage.Document.FileText = _selectedTabPage.MyPanel.TextBox1.Text;

            tabControl1.SelectedTab.Text = openFileDialog1.SafeFileName;
            _selectedTabPage.Document.Name = openFileDialog1.SafeFileName;

         }
      }

      public void LineNumber()
      {
         string line = "1";
         MyTabPage currentTab = (MyTabPage)tabControl1.SelectedTab;
         SyncTextBox textBox1 = currentTab.MyPanel.TextBox1;
         SyncTextBox textBox2 = currentTab.MyPanel.TextBox2;
         // if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back) {
         if ( textBox1.Lines.Count() == 0 ) {
            textBox2.Text = "1";
         }
         for ( int i = 2; i <= textBox1.Lines.Count(); i++ ) {
            line += Environment.NewLine + i.ToString();
         }
         if ( !textBox2.Text.Equals( line ) ) {
            textBox2.ResetText();
            textBox2.Text = line;
         }
         //move the cursor to the last line
         textBox2.SelectionStart = textBox2.Text.Length;
         textBox2.ScrollToCaret();
      }

      public void SaveAs()
      {
         //MyTabPage tabPage = (MyTabPage)tabControl1.SelectedTab;
         SaveFileDialog savefile = new SaveFileDialog();
         // set a default file name
         savefile.FileName = savefile.FileName;
         // set filters - this can be done in properties as well
         savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

         if ( savefile.ShowDialog() == DialogResult.OK ) {
            using ( StreamWriter sw = new StreamWriter( savefile.FileName ) )
               sw.Write(_selectedTabPage.MyPanel.TextBox1.Text );
           
         }
         tabControl1.SelectedTab.Text = savefile.FileName;
      }

      public void Find(Form1 form)
      {
         Notepad.FindForm findForm = new FindForm(form);
         findForm.Show();

      }
   }
}
