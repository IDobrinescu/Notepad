using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
   public partial class OpenForm : Form
   {
      private DBControler dbControler;
      private Form1 _form1;
      public OpenForm(Form1 form1)
      {
         InitializeComponent();
         _form1 = form1;
         MyTabPage tabPage = (MyTabPage) form1.tabControl.SelectedTab;
         dbControler = new DBControler(form1);
      }

      private void filesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.filesTableBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.myLocalDBDataSet);

      }

      private void OpenForm_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'myLocalDBDataSet.FilesTable' table. You can move, or remove it, as needed.
         this.filesTableTableAdapter.Fill(this.myLocalDBDataSet.FilesTable);

      }

      private void OpenButton_Click(object sender, EventArgs e)
      {
         //MyTabPage tabPage = (MyTabPage)_form1.tabControl.SelectedTab;
          dbControler.OpenFromDb(textBox1.Text);
         
         this.Hide();
      }
   }
}
