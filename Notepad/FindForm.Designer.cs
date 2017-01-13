namespace Notepad
{
   partial class FindForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

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
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.findTextBox = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.replaceButton = new System.Windows.Forms.Button();
         this.replaceTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // findTextBox
         // 
         this.findTextBox.Location = new System.Drawing.Point(31, 29);
         this.findTextBox.Name = "findTextBox";
         this.findTextBox.Size = new System.Drawing.Size(100, 20);
         this.findTextBox.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(137, 29);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(71, 20);
         this.button1.TabIndex = 1;
         this.button1.Text = "Find";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // replaceButton
         // 
         this.replaceButton.Location = new System.Drawing.Point(137, 55);
         this.replaceButton.Name = "replaceButton";
         this.replaceButton.Size = new System.Drawing.Size(71, 20);
         this.replaceButton.TabIndex = 2;
         this.replaceButton.Text = "Replace";
         this.replaceButton.UseVisualStyleBackColor = true;
         this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
         // 
         // replaceTextBox
         // 
         this.replaceTextBox.Location = new System.Drawing.Point(31, 55);
         this.replaceTextBox.Name = "replaceTextBox";
         this.replaceTextBox.Size = new System.Drawing.Size(100, 20);
         this.replaceTextBox.TabIndex = 3;
         // 
         // FindForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(228, 103);
         this.Controls.Add(this.replaceTextBox);
         this.Controls.Add(this.replaceButton);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.findTextBox);
         this.Name = "FindForm";
         this.Text = "FindForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox findTextBox;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button replaceButton;
      private System.Windows.Forms.TextBox replaceTextBox;
   }
}