using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
   public class Document: IDocument
   {
      public string Name { get; set; }
      public string FilePath { get; set; }
      public string FileText { get; set; }
      public string UserName { get; set; }
   }
}
