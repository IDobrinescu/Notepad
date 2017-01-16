namespace Notepad
{
   partial class SaveAsToDB
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveAsToDB));
         this.myLocalDBDataSet = new Notepad.MyLocalDBDataSet();
         this.filesTabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.filesTabelTableAdapter = new Notepad.MyLocalDBDataSetTableAdapters.FilesTabelTableAdapter();
         this.tableAdapterManager = new Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager();
         this.filesTabelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.filesTabelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.filesTabelDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.fileNameTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SaveBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingNavigator)).BeginInit();
         this.filesTabelBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // myLocalDBDataSet
         // 
         this.myLocalDBDataSet.DataSetName = "MyLocalDBDataSet";
         this.myLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // filesTabelBindingSource
         // 
         this.filesTabelBindingSource.DataMember = "FilesTabel";
         this.filesTabelBindingSource.DataSource = this.myLocalDBDataSet;
         // 
         // filesTabelTableAdapter
         // 
         this.filesTabelTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.FilesTabelTableAdapter = this.filesTabelTableAdapter;
         this.tableAdapterManager.UpdateOrder = Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UsersTableTableAdapter = null;
         // 
         // filesTabelBindingNavigator
         // 
         this.filesTabelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.filesTabelBindingNavigator.BindingSource = this.filesTabelBindingSource;
         this.filesTabelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.filesTabelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.filesTabelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filesTabelBindingNavigatorSaveItem});
         this.filesTabelBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.filesTabelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.filesTabelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.filesTabelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.filesTabelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.filesTabelBindingNavigator.Name = "filesTabelBindingNavigator";
         this.filesTabelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.filesTabelBindingNavigator.Size = new System.Drawing.Size(490, 25);
         this.filesTabelBindingNavigator.TabIndex = 0;
         this.filesTabelBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // filesTabelBindingNavigatorSaveItem
         // 
         this.filesTabelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.filesTabelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filesTabelBindingNavigatorSaveItem.Image")));
         this.filesTabelBindingNavigatorSaveItem.Name = "filesTabelBindingNavigatorSaveItem";
         this.filesTabelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.filesTabelBindingNavigatorSaveItem.Text = "Save Data";
         this.filesTabelBindingNavigatorSaveItem.Click += new System.EventHandler(this.filesTabelBindingNavigatorSaveItem_Click);
         // 
         // filesTabelDataGridView
         // 
         this.filesTabelDataGridView.AutoGenerateColumns = false;
         this.filesTabelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.filesTabelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
         this.filesTabelDataGridView.DataSource = this.filesTabelBindingSource;
         this.filesTabelDataGridView.Location = new System.Drawing.Point(0, 28);
         this.filesTabelDataGridView.Name = "filesTabelDataGridView";
         this.filesTabelDataGridView.Size = new System.Drawing.Size(300, 220);
         this.filesTabelDataGridView.TabIndex = 1;
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
         // fileNameTextBox
         // 
         this.fileNameTextBox.Location = new System.Drawing.Point(104, 266);
         this.fileNameTextBox.Name = "fileNameTextBox";
         this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
         this.fileNameTextBox.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(44, 269);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(54, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "File Name";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // SaveBtn
         // 
         this.SaveBtn.Location = new System.Drawing.Point(225, 264);
         this.SaveBtn.Name = "SaveBtn";
         this.SaveBtn.Size = new System.Drawing.Size(75, 23);
         this.SaveBtn.TabIndex = 4;
         this.SaveBtn.Text = "Save";
         this.SaveBtn.UseVisualStyleBackColor = true;
         this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
         // 
         // SaveAsToDB
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(490, 340);
         this.Controls.Add(this.SaveBtn);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.fileNameTextBox);
         this.Controls.Add(this.filesTabelDataGridView);
         this.Controls.Add(this.filesTabelBindingNavigator);
         this.Name = "SaveAsToDB";
         this.Text = "SaveAsToDB";
         this.Load += new System.EventHandler(this.SaveAsToDB_Load);
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingNavigator)).EndInit();
         this.filesTabelBindingNavigator.ResumeLayout(false);
         this.filesTabelBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private MyLocalDBDataSet myLocalDBDataSet;
      private System.Windows.Forms.BindingSource filesTabelBindingSource;
      private MyLocalDBDataSetTableAdapters.FilesTabelTableAdapter filesTabelTableAdapter;
      private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator filesTabelBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton filesTabelBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView filesTabelDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.TextBox fileNameTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button SaveBtn;
   }
}