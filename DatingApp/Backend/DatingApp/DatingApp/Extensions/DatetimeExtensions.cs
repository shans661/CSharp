using System;

namespace DatingApp.Extensions
{
    public static class DatetimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            return DateTime.Now.Year - dob.Year;
        }
    }
}