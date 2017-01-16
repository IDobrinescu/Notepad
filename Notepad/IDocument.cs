using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
   public interface IDocument
   {
      string Name { get; set; }
      string FilePath { get; set; }
      string UserName { get; set; }

   }
}
