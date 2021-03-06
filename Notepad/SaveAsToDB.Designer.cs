﻿namespace Notepad
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
         this.fileNameTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SaveBtn = new System.Windows.Forms.Button();
         this.myLocalDBDataSet = new Notepad.MyLocalDBDataSet();
         this.tableAdapterManager = new Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager();
         this.filesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.filesTableTableAdapter = new Notepad.MyLocalDBDataSetTableAdapters.FilesTableTableAdapter();
         this.filesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.filesTableDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableDataGridView)).BeginInit();
         this.SuspendLayout();
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
         // myLocalDBDataSet
         // 
         this.myLocalDBDataSet.DataSetName = "MyLocalDBDataSet";
         this.myLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.Connection = null;
         this.tableAdapterManager.FilesTableTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UsersTableTableAdapter = null;
         // 
         // filesTableBindingSource
         // 
         this.filesTableBindingSource.DataSource = this.myLocalDBDataSet;
         this.filesTableBindingSource.Position = 0;
         // 
         // filesTableTableAdapter
         // 
         this.filesTableTableAdapter.ClearBeforeFill = true;
         // 
         // filesTableBindingSource1
         // 
         this.filesTableBindingSource1.DataMember = "FilesTable";
         this.filesTableBindingSource1.DataSource = this.myLocalDBDataSet;
         // 
         // filesTableDataGridView
         // 
         this.filesTableDataGridView.AutoGenerateColumns = false;
         this.filesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.filesTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
         this.filesTableDataGridView.DataSource = this.filesTableBindingSource1;
         this.filesTableDataGridView.Location = new System.Drawing.Point(33, 25);
         this.filesTableDataGridView.Name = "filesTableDataGridView";
         this.filesTableDataGridView.Size = new System.Drawing.Size(300, 220);
         this.filesTableDataGridView.TabIndex = 4;
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
         // SaveAsToDB
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(490, 340);
         this.Controls.Add(this.filesTableDataGridView);
         this.Controls.Add(this.SaveBtn);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.fileNameTextBox);
         this.Name = "SaveAsToDB";
         this.Text = "SaveAsToDB";
         this.Load += new System.EventHandler(this.SaveAsToDB_Load);
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableBindingSource1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTableDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private MyLocalDBDataSet myLocalDBDataSet;
      private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.TextBox fileNameTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button SaveBtn;
      private System.Windows.Forms.BindingSource filesTableBindingSource;
      private MyLocalDBDataSetTableAdapters.FilesTableTableAdapter filesTableTableAdapter;
      private System.Windows.Forms.BindingSource filesTableBindingSource1;
      private System.Windows.Forms.DataGridView filesTableDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
   }
}