using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class HoildayService
    {
        public string IsXmas()
        {
            DateTime xMas = GetToday();
            if (xMas.Month == 12 && xMas.Day == 25)
            {
                return "Merry Xmas";
            }
            return "Today is not Xmas";
        }
        protected virtual DateTime GetToday()
        {
            return DateTime.Now;
        }
    }
}
