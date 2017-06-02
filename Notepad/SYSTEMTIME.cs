using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
   [StructLayout(LayoutKind.Sequential)]
   public struct SYSTEMTIME
   {
      public ushort wYear;//ushort = WORD
      public ushort wMonth;
      public ushort wDayOfWeek;
      ushort wDay;
      public ushort wHour;
      public ushort wMinute;
      ushort wSecond;
      ushort wMilliseconds;
   }

   public enum EWeekDays
   {
      Luni =1,
      Marti,
      Miercuri,
      Joi,
      Vineri,
      Sambata,
      Duminica
   }

   public enum EMonths
   {
      Ian = 1,
      Feb,
      Mar,
      Apr,
      Mai,
      Iun,
      Iul,
      Aug,
      Sep,
      Oct,
      Noi,
      Dec
   }
}
