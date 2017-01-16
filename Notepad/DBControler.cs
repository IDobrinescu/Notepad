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
      private MyLocalDBDataSetTableAdapters.FilesTabelTableAdapter _filesTabelTableAdapter;
      public Document Document1
      {
         get { return _document; }
         set { _document = value; }
      }

      public DBControler(Document document, MyLocalDBDataSetTableAdapters.FilesTabelTableAdapter filesTabelTableAdapter)
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
         frm.UsersTabelTableAdapter.Insert(frm.IdSignUpTextBox.Text, frm.PsSignUpTextBox.Text);
      }

      public void SaveAsToDB()
      {
         
      }
   }
}
