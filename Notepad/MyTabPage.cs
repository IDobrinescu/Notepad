using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Notepad
{
   class MyTabPage:TabPage
   {
      public MyPanel MyPanel { get; set; }
      public Document Document { get; set; }

      public MyTabPage(MyPanel p)
      {
         Document = new Document();
         Document.Name = this.Text;
         MyPanel = p;
      }
   }
}
