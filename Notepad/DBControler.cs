using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
   public class DBControler
   {
      private Document _document;
      private MyLocalDBDataSetTableAdapters.FilesTableTableAdapter _filesTabelTableAdapter;
      private Form1 _form1;
      private MyTabPage _curentTabPage;
      public Document Document1
      {
         get { return _document; }
         set { _document = value; }
      }

      public DBControler(Form1 form1)
      {
         _form1 = form1;
         _curentTabPage = (MyTabPage) form1.tabControl.SelectedTab;
         _filesTabelTableAdapter = form1.FilesTabelTableAdapter;
         _document = _curentTabPage.Document;
      }
      public DBControler(Document document, MyLocalDBDataSetTableAdapters.FilesTableTableAdapter filesTabelTableAdapter)
      {
         _document = document;
         _filesTabelTableAdapter = filesTabelTableAdapter;
      }
      public static void LogIn(LoginFrom frm)
      {
         var result = frm.UsersTabelTableAdapter.GetDataBy1(frm.IDTextBox.Text, frm.PasswordTextBox.Text);
         if (result.Any())
         {
            Form1 form1 = new Form1(frm.IDTextBox.Text);
            form1.Show();
            form1.Activate();
            frm.Hide();
         }
         else
         {
            MessageBox.Show("Failed");
         }
      }

      public static void SignUp(LoginFrom frm)
      {
         try
         {
            frm.UsersTabelTableAdapter.Insert(frm.IdSignUpTextBox.Text, frm.PsSignUpTextBox.Text);
            MessageBox.Show("Account Created");
         }
         catch (Exception e)
         {
            MessageBox.Show("User Name already exists");
         }
      }

      public void OpenFromDb(string FileName)
      {
         _document.Name = FileName;
         _document.FileText = _filesTabelTableAdapter.ScalarQuery(FileName, _document.UserName);
         if (_document.FileText == null)
         {
            MessageBox.Show("File does not exist");
         }
         else
         {
            _curentTabPage.MyPanel.TextBox1.Text = _filesTabelTableAdapter.ScalarQuery(FileName, _document.UserName);
            _curentTabPage.Text = FileName;
         }


          

      }
   }
}
