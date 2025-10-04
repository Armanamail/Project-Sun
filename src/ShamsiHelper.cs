using System;
using Microsoft.Office.Interop.MSProject;

namespace ProjectShamsi
{
    public class ShamsiHelper
    {
        public static string ToShamsi(DateTime date)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
    }
}
