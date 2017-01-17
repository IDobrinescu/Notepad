namespace Notepad
{
   partial class OpenForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.myLocalDBDataSet = new Notepad.MyLocalDBDataSet();
         this.filesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.filesTableTableAdapter = new Notepad.MyLocalDBDataSetTableAdapters.FilesTableTableAdapter();
         this.tableAdapterManager = new Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager();
         this.filesTableDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.OpenButton = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // myLocalDBDataSet
         // 
         this.myLocalDBDataSet.DataSetName = "MyLocalDBDataSet";
         this.myLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // filesTableBindingSource
         // 
         this.filesTableBindingSource.DataMember = "FilesTable";
         this.filesTableBindingSource.DataSource = this.myLocalDBDataSet;
         // 
         // filesTableTableAdapter
         // 
         this.filesTableTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.FilesTableTableAdapter = this.filesTableTableAdapter;
         this.tableAdapterManager.UpdateOrder = Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UsersTableTableAdapter = null;
         // 
         // filesTableDataGridView
         // 
         this.filesTableDataGridView.AutoGenerateColumns = false;
         this.filesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.filesTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
         this.filesTableDataGridView.DataSource = this.filesTableBindingSource;
         this.filesTableDataGridView.Location = new System.Drawing.Point(12, 12);
         this.filesTableDataGridView.Name = "filesTableDataGridView";
         this.filesTableDataGridView.Size = new System.Drawing.Size(300, 220);
         this.filesTableDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "FileName";
         this.dataGridViewTextBoxColumn1.HeaderText = "FileName";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
         this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Text";
         this.dataGridViewTextBoxColumn3.HeaderText = "Text";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // OpenButton
         // 
         this.OpenButton.Location = new System.Drawing.Point(183, 259);
         this.OpenButton.Name = "OpenButton";
         this.OpenButton.Size = new System.Drawing.Size(75, 23);
         this.OpenButton.TabIndex = 2;
         this.OpenButton.Text = "Open";
         this.OpenButton.UseVisualStyleBackColor = true;
         this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(65, 262);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 3;
         // 
         // OpenForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(388, 303);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.OpenButton);
         this.Controls.Add(this.filesTableDataGridView);
         this.Name = "OpenForm";
         this.Text = "OpenForm";
         this.Load += new System.EventHandler(this.OpenForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private MyLocalDBDataSet myLocalDBDataSet;
      private System.Windows.Forms.BindingSource filesTableBindingSource;
      private MyLocalDBDataSetTableAdapters.FilesTableTableAdapter filesTableTableAdapter;
      private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.DataGridView filesTableDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.Button OpenButton;
      private System.Windows.Forms.TextBox textBox1;
   }
}