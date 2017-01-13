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

      public MyTabPage(MyPanel p)
      {
          MyPanel = p;
      }
   }
}
