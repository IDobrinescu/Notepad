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
   public partial class DeleteForm : Form
   {
      private DBControler dbControler;
      public DeleteForm(Form1 form1)
      {
         InitializeComponent();
         dbControler = new DBControler(form1);
      }

      private void filesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.filesTableBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.myLocalDBDataSet);

      }

      private void DeleteForm_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'myLocalDBDataSet.FilesTable' table. You can move, or remove it, as needed.
         this.filesTableTableAdapter.Fill(this.myLocalDBDataSet.FilesTable);

      }

      private void button1_Click(object sender, EventArgs e)
      {
         dbControler.DeleteFile(textBox1.Text);
         this.Hide();
      }
   }
}
