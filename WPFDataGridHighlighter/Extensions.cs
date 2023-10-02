using System;

namespace WPFDataGridHighlighter
{
    public static class Extensions
    {
        public static bool IsNumeric(this object val)
        {
            double test;
            return double.TryParse(val.ToString(), out test);
        }

        public static double ToDouble(this object val)
        {
            return Convert.ToDouble(val);
        }
    }
}
