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
         var result = usersTabelTableAdapter.GetDataBy1(iDTextBox.Text, passwordTextBox.Text);
         if (result.Any())
         {
            MessageBox.Show("Success");
            Form1 form1 = new Form1();
            form1.Show();
            form1.Activate();
            this.Hide();
         }
         else
         {
            MessageBox.Show("Failed");
         }
      }

      private void LoginFrom_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'myLocalDBDataSet.UsersTabel' table. You can move, or remove it, as needed.
         this.usersTabelTableAdapter.Fill(this.myLocalDBDataSet.UsersTable);

      }

      private void createAccBtn_Click(object sender, EventArgs e)
      {
         usersTabelTableAdapter.Insert(this.idSignUpTextBox.Text, psSignUpTextBox.Text);
      }
   }
}
