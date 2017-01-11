using System.Windows.Forms;


namespace Notepad
{
   class MyPanel:Panel
   {
      public SyncTextBox TextBox1;
      public SyncTextBox TextBox2;

      public MyPanel()
      {
         TextBox1 = new SyncTextBox();
         TextBox2 = new SyncTextBox();
         // 
         // panel1
         // 
         Controls.Add( TextBox1 );
         Controls.Add( TextBox2 );
         Location = new System.Drawing.Point( 3, 6 );
         Name = "panel1";
         Size = new System.Drawing.Size( 528, 362 );
         TabIndex = 3;
         // 
         // textBox1
         // 
         TextBox1.Buddy = TextBox2;
         TextBox1.Location = new System.Drawing.Point( 28, 0 );
         TextBox1.Multiline = true;
         TextBox1.Name = "textBox1";
         TextBox1.ScrollBars = ScrollBars.Vertical;
         TextBox1.Size = new System.Drawing.Size( 494, 365 );
         TextBox1.TabIndex = 0;
         //this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler( this.Parent.textBox1_KeyUp );
         // 
         // textBox2
         // 
         TextBox2.AcceptsReturn = true;
         TextBox2.AcceptsTab = true;
         TextBox2.Buddy = TextBox1;
         TextBox2.Location = new System.Drawing.Point( -3, 0 );
         TextBox2.Multiline = true;
         TextBox2.Name = "textBox2";
         TextBox2.ReadOnly = true;
         TextBox2.ScrollBars = ScrollBars.Vertical;
         TextBox2.Size = new System.Drawing.Size( 55, 367 );
         TextBox2.TabIndex = 2;
         TextBox2.Text = "1";
         TextBox2.TextAlign = HorizontalAlignment.Center;
      }
   }
}
