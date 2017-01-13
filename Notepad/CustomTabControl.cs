using System.Drawing;
using System.Windows.Forms;


namespace Notepad
{

   public class CustomTabControl : TabControl
   {
      Rectangle closeX = Rectangle.Empty;

      public CustomTabControl()
      {

         this.DrawMode = TabDrawMode.OwnerDrawFixed;
      }

      protected override void OnDrawItem(DrawItemEventArgs e)
      {
         Size xSize = new Size(15, 15);
         TabPage tp = this.TabPages[e.Index];
         e.DrawBackground();
         using (SolidBrush brush = new SolidBrush(e.ForeColor)) e.Graphics.DrawString(tp.Text + "  ", e.Font, brush, e.Bounds.X + 5, e.Bounds.Y + 5);

         if (e.State == DrawItemState.Selected) {
            closeX = new Rectangle(e.Bounds.Right - xSize.Width, e.Bounds.Top, xSize.Width + 5, xSize.Height + 5);
            using (SolidBrush brush = new SolidBrush(Color.Black)) e.Graphics.DrawString("x", e.Font, brush, e.Bounds.Right - xSize.Width, e.Bounds.Y + 4);
         }


      }

      protected override void OnMouseClick(MouseEventArgs e)
      {
         if (closeX.Contains(e.Location)) {
            this.TabPages.Remove(this.SelectedTab);
            this.SelectedTab = this.TabPages[TabCount - 1];
         }
      }
   }
}

