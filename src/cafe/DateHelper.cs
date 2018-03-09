using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cafe
{
    public class DateTimeHelper
    {
        public static DateTime? ParseDate(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                DateTime date = DateTime.MinValue;
                if (DateTime.TryParse(input, out date))
                {
                    return date;
                }
            }
            return null;
        }
      
    }
}
