using System.Windows.Forms;
using Notepad.MyLocalDBDataSetTableAdapters;


namespace Notepad
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      public FilesTableTableAdapter FilesTabelTableAdapter
      {
         get { return filesTableTableAdapter; }
         set { filesTableTableAdapter = value; }
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) ) {
            components.Dispose();
         }
         base.Dispose( disposing );
         Application.Exit();
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         Notepad.Document document1 = new Notepad.Document();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1 = new Notepad.MyPanel();
         tabPage1 = new MyTabPage(panel1);
         this.textBox1 = new Notepad.SyncTextBox();
         this.textBox2 = new Notepad.SyncTextBox();
         this.tabControl1 = new Notepad.CustomTabControl();
         this.myLocalDBDataSet = new Notepad.MyLocalDBDataSet();
         this.filesTabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.filesTableTableAdapter = new Notepad.MyLocalDBDataSetTableAdapters.FilesTableTableAdapter();
         this.tableAdapterManager = new Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToDBToolStripMenuItem,
            this.saveAsToDBToolStripMenuItem,
            this.openFromDBToolStripMenuItem});
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
         this.toolStripMenuItem1.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.openToolStripMenuItem.Text = "Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // newFileToolStripMenuItem
         // 
         this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
         this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
         this.newFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.newFileToolStripMenuItem.Text = "New File";
         this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
         // 
         // saveAsToolStripMenuItem
         // 
         this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.saveAsToolStripMenuItem.Text = "Save As";
         this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
         // 
         // saveToDBToolStripMenuItem
         // 
         this.saveToDBToolStripMenuItem.Name = "saveToDBToolStripMenuItem";
         this.saveToDBToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.saveToDBToolStripMenuItem.Text = "Save to DB";
         this.saveToDBToolStripMenuItem.Click += new System.EventHandler(this.saveToDBToolStripMenuItem_Click);
         // 
         // saveAsToDBToolStripMenuItem
         // 
         this.saveAsToDBToolStripMenuItem.Name = "saveAsToDBToolStripMenuItem";
         this.saveAsToDBToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.saveAsToDBToolStripMenuItem.Text = "Save As to DB";
         this.saveAsToDBToolStripMenuItem.Click += new System.EventHandler(this.saveAsToDBToolStripMenuItem_Click);
         // 
         // openFromDBToolStripMenuItem
         // 
         this.openFromDBToolStripMenuItem.Name = "openFromDBToolStripMenuItem";
         this.openFromDBToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
         this.openFromDBToolStripMenuItem.Text = "Open from DB";
         this.openFromDBToolStripMenuItem.Click += new System.EventHandler(this.openFromDBToolStripMenuItem_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(549, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
         this.editToolStripMenuItem.Text = "Edit";
         // 
         // findToolStripMenuItem
         // 
         this.findToolStripMenuItem.Name = "findToolStripMenuItem";
         this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
         this.findToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this.findToolStripMenuItem.Text = "Find";
         this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
         // 
         // panel1
         // 
         this.panel1.AllowDrop = true;
         this.panel1.Controls.Add(this.textBox1);
         this.panel1.Controls.Add(this.textBox2);
         this.panel1.Location = new System.Drawing.Point(3, 6);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(530, 362);
         this.panel1.TabIndex = 3;
         this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
         this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
         // 
         // textBox1
         // 
         this.textBox1.AcceptsTab = true;
         this.textBox1.AllowDrop = true;
         this.textBox1.Buddy = this.textBox2;
         this.textBox1.Location = new System.Drawing.Point(28, 0);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox1.Size = new System.Drawing.Size(494, 365);
         this.textBox1.TabIndex = 0;
         // 
         // textBox2
         // 
         this.textBox2.AcceptsReturn = true;
         this.textBox2.AcceptsTab = true;
         this.textBox2.Buddy = this.textBox1;
         this.textBox2.Location = new System.Drawing.Point(-3, 0);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.ReadOnly = true;
         this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox2.Size = new System.Drawing.Size(55, 367);
         this.textBox2.TabIndex = 2;
         this.textBox2.Text = "1";
         this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // tabPage1
         // 
         this.tabPage1.AllowDrop = true;
         this.tabPage1.Controls.Add(this.panel1);
         document1.FilePath = null;
         document1.FileText = null;
         document1.Name = "";
         document1.UserName = null;
         this.tabPage1.Document = document1;
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.MyPanel = this.panel1;
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(507, 368);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "New";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabControl1
         // 
         this.tabControl1.AllowDrop = true;
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
         this.tabControl1.Location = new System.Drawing.Point(12, 27);
         this.tabControl1.Multiline = true;
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(515, 394);
         this.tabControl1.TabIndex = 4;
         this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
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
         this.filesTableTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.FilesTableTableAdapter = this.filesTableTableAdapter;
         this.tableAdapterManager.UpdateOrder = Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UsersTableTableAdapter = null;
         // 
         // Form1
         // 
         this.AllowDrop = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(549, 441);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.menuStrip1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.tabPage1.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
         //((System.ComponentModel.ISupportInitialize)(this.filesTabelBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private SyncTextBox textBox1;
      private SyncTextBox textBox2;
      private MyPanel panel1;
      private CustomTabControl tabControl1;
      private MyTabPage tabPage1;
      private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private ToolStripMenuItem editToolStripMenuItem;
      private ToolStripMenuItem findToolStripMenuItem;
      private ToolStripMenuItem saveToDBToolStripMenuItem;
      private MyLocalDBDataSet myLocalDBDataSet;
      private BindingSource filesTabelBindingSource;
      private MyLocalDBDataSetTableAdapters.FilesTableTableAdapter filesTableTableAdapter;
      private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private ToolStripMenuItem saveAsToDBToolStripMenuItem;
      private ToolStripMenuItem openFromDBToolStripMenuItem;
   }
}

