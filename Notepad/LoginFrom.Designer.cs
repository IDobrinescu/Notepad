using System.Windows.Forms;
using Notepad.MyLocalDBDataSetTableAdapters;

namespace Notepad
{
   partial class LoginFrom
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      public TextBox IDTextBox
      {
         get { return iDTextBox; }
         set { iDTextBox = value; }
      }

      public TextBox PasswordTextBox
      {
         get { return passwordTextBox; }
         set { passwordTextBox = value; }
      }

      public UsersTableTableAdapter UsersTabelTableAdapter
      {
         get { return usersTabelTableAdapter; }
         set { usersTabelTableAdapter = value; }
      }

      public TextBox IdSignUpTextBox
      {
         get { return idSignUpTextBox; }
         set { idSignUpTextBox = value; }
      }

      public TextBox PsSignUpTextBox
      {
         get { return psSignUpTextBox; }
         set { psSignUpTextBox = value; }
      }


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
         System.Windows.Forms.Label iDLabel;
         System.Windows.Forms.Label passwordLabel;
         this.label1 = new System.Windows.Forms.Label();
         this.signInBtn = new System.Windows.Forms.Button();
         this.createAccBtn = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.myLocalDBDataSet = new Notepad.MyLocalDBDataSet();
         this.iDTextBox = new System.Windows.Forms.TextBox();
         this.passwordTextBox = new System.Windows.Forms.TextBox();
         this.usersTabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.usersTabelTableAdapter = new Notepad.MyLocalDBDataSetTableAdapters.UsersTableTableAdapter();
         this.tableAdapterManager = new Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager();
         this.filesTabelTableAdapter1 = new Notepad.MyLocalDBDataSetTableAdapters.FilesTableTableAdapter();
         this.ID = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.idSignUpTextBox = new System.Windows.Forms.TextBox();
         this.psSignUpTextBox = new System.Windows.Forms.TextBox();
         this.rePassTextBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         iDLabel = new System.Windows.Forms.Label();
         passwordLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.usersTabelBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // iDLabel
         // 
         iDLabel.AutoSize = true;
         iDLabel.Location = new System.Drawing.Point(48, 83);
         iDLabel.Name = "iDLabel";
         iDLabel.Size = new System.Drawing.Size(21, 13);
         iDLabel.TabIndex = 9;
         iDLabel.Text = "ID:";
         // 
         // passwordLabel
         // 
         passwordLabel.AutoSize = true;
         passwordLabel.Location = new System.Drawing.Point(13, 109);
         passwordLabel.Name = "passwordLabel";
         passwordLabel.Size = new System.Drawing.Size(56, 13);
         passwordLabel.TabIndex = 10;
         passwordLabel.Text = "Password:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(72, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "LogIn";
         // 
         // signInBtn
         // 
         this.signInBtn.Location = new System.Drawing.Point(75, 150);
         this.signInBtn.Name = "signInBtn";
         this.signInBtn.Size = new System.Drawing.Size(75, 23);
         this.signInBtn.TabIndex = 5;
         this.signInBtn.Text = "SignIn";
         this.signInBtn.UseVisualStyleBackColor = true;
         this.signInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
         // 
         // createAccBtn
         // 
         this.createAccBtn.Location = new System.Drawing.Point(291, 181);
         this.createAccBtn.Name = "createAccBtn";
         this.createAccBtn.Size = new System.Drawing.Size(92, 23);
         this.createAccBtn.TabIndex = 6;
         this.createAccBtn.Text = "Create Account";
         this.createAccBtn.UseVisualStyleBackColor = true;
         this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(247, 44);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(171, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "If you don\'t have an acc click here";
         // 
         // myLocalDBDataSet
         // 
         this.myLocalDBDataSet.DataSetName = "MyLocalDBDataSet";
         this.myLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // iDTextBox
         // 
         this.iDTextBox.Location = new System.Drawing.Point(75, 80);
         this.iDTextBox.Name = "iDTextBox";
         this.iDTextBox.Size = new System.Drawing.Size(100, 20);
         this.iDTextBox.TabIndex = 10;
         // 
         // passwordTextBox
         // 
         this.passwordTextBox.Location = new System.Drawing.Point(75, 106);
         this.passwordTextBox.Name = "passwordTextBox";
         this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
         this.passwordTextBox.TabIndex = 11;
         this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
         // 
         // usersTabelBindingSource
         // 
         this.usersTabelBindingSource.DataMember = "UsersTabel";
         this.usersTabelBindingSource.DataSource = this.myLocalDBDataSet;
         // 
         // usersTabelTableAdapter
         // 
         this.usersTabelTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.FilesTableTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Notepad.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UsersTableTableAdapter = this.usersTabelTableAdapter;
         // 
         // filesTabelTableAdapter1
         // 
         this.filesTabelTableAdapter1.ClearBeforeFill = true;
         // 
         // ID
         // 
         this.ID.AutoSize = true;
         this.ID.Location = new System.Drawing.Point(250, 82);
         this.ID.Name = "ID";
         this.ID.Size = new System.Drawing.Size(18, 13);
         this.ID.TabIndex = 12;
         this.ID.Text = "ID";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(232, 109);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 13;
         this.label3.Text = "Password";
         // 
         // idSignUpTextBox
         // 
         this.idSignUpTextBox.Location = new System.Drawing.Point(292, 80);
         this.idSignUpTextBox.Name = "idSignUpTextBox";
         this.idSignUpTextBox.Size = new System.Drawing.Size(100, 20);
         this.idSignUpTextBox.TabIndex = 14;
         // 
         // psSignUpTextBox
         // 
         this.psSignUpTextBox.Location = new System.Drawing.Point(291, 106);
         this.psSignUpTextBox.Name = "psSignUpTextBox";
         this.psSignUpTextBox.Size = new System.Drawing.Size(100, 20);
         this.psSignUpTextBox.TabIndex = 15;
         // 
         // rePassTextBox
         // 
         this.rePassTextBox.Location = new System.Drawing.Point(291, 132);
         this.rePassTextBox.Name = "rePassTextBox";
         this.rePassTextBox.Size = new System.Drawing.Size(100, 20);
         this.rePassTextBox.TabIndex = 16;
         this.rePassTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(188, 135);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 13);
         this.label2.TabIndex = 17;
         this.label2.Text = "Re-enter Password";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(289, 165);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(0, 13);
         this.label5.TabIndex = 18;
         // 
         // LoginFrom
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(455, 261);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.rePassTextBox);
         this.Controls.Add(this.psSignUpTextBox);
         this.Controls.Add(this.idSignUpTextBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.ID);
         this.Controls.Add(passwordLabel);
         this.Controls.Add(this.passwordTextBox);
         this.Controls.Add(iDLabel);
         this.Controls.Add(this.iDTextBox);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.createAccBtn);
         this.Controls.Add(this.signInBtn);
         this.Controls.Add(this.label1);
         this.Name = "LoginFrom";
         this.Text = "LoginFrom";
         this.Load += new System.EventHandler(this.LoginFrom_Load);
         ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
         //((System.ComponentModel.ISupportInitialize)(this.usersTabelBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button signInBtn;
      private System.Windows.Forms.Button createAccBtn;
      private System.Windows.Forms.Label label4;
      private MyLocalDBDataSet myLocalDBDataSet;
      private System.Windows.Forms.TextBox iDTextBox;
      private System.Windows.Forms.TextBox passwordTextBox;
      private System.Windows.Forms.BindingSource usersTabelBindingSource;
      private MyLocalDBDataSetTableAdapters.UsersTableTableAdapter usersTabelTableAdapter;
      private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private MyLocalDBDataSetTableAdapters.FilesTableTableAdapter filesTabelTableAdapter1;
      private System.Windows.Forms.Label ID;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox idSignUpTextBox;
      private System.Windows.Forms.TextBox psSignUpTextBox;
      private TextBox rePassTextBox;
      private Label label2;
      private Label label5;
   }
}