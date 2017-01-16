using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Notepad
{
   public partial class LoginFrom : Form
   {
      public LoginFrom()
      {
         InitializeComponent();
      }

      private void SignInBtn_Click(object sender, EventArgs e)
      {
         DBControler.LogIn(this);
      }

      private void LoginFrom_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'myLocalDBDataSet.UsersTabel' table. You can move, or remove it, as needed.
         this.usersTabelTableAdapter.Fill(this.myLocalDBDataSet.UsersTable);
      }

      private void createAccBtn_Click(object sender, EventArgs e)
      {
         DBControler.SignUp(this);
      }

      private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            DBControler.LogIn(this);
         }
      }
   }
}
