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
   public partial class SaveAsToDB : Form
   {
      private Form1 _form1;
      public SaveAsToDB(Form1 form1)
      {
         InitializeComponent();
         _form1 = form1;
      }

      private void filesTabelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.filesTableBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.myLocalDBDataSet);

      }

      private void SaveAsToDB_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'myLocalDBDataSet.FilesTable' table. You can move, or remove it, as needed.
         this.filesTableTableAdapter.Fill(this.myLocalDBDataSet.FilesTable);
         // TODO: This line of code loads data into the 'myLocalDBDataSet.FilesTabel' table. You can move, or remove it, as needed.
         this.filesTableTableAdapter.Fill(this.myLocalDBDataSet.FilesTable);

      }

      private void SaveBtn_Click(object sender, EventArgs e)
      {
         MyTabPage selecteTabPage = (MyTabPage) _form1.tabControl.SelectedTab;
         filesTableTableAdapter.Insert(this.fileNameTextBox.Text, selecteTabPage.Document.UserName,
            selecteTabPage.MyPanel.TextBox1.Text);
         MessageBox.Show("File saved to Database");
         this.Hide();
      }
   }
}
