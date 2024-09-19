using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class DateTimeExtentions
    {
        public static int CalculateAge(this DateOnly dod)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            var age = today.Year - dod.Year;

            if (dod > today.AddYears(-age)) age--;

            return age;
        }
    }
}
