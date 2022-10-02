using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Core
{
    public static class Constant
    {
        public static readonly String CR = Convert.ToChar(13).ToString();
        public static readonly String CRLF = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
        public static readonly String LF = Convert.ToChar(10).ToString();
    }

    public static class ASCII
    {
        public static String Printable(String Data)
        {
            Regex RegEx = new Regex(@"\p{C}+");
            Data = RegEx.Replace(Data, "");

            while (Data.Contains("  "))
            {
                Data = Regex.Replace(Data, "  ", " ");
            }

            return Data;
        }

        public static String Readable(String Data)
        {
            Regex RegEx = new Regex(@"[^ -~]+");
            Data = RegEx.Replace(Data, "");

            while (Data.Contains("  "))
            {
                Data = Regex.Replace(Data, "  ", " ");
            }

            return Data;
        }

        public static String AlphaNumeric(String Data)
        {
            Regex RegEx = new Regex(@"[^a-zA-Z0-9]");
            Data = RegEx.Replace(Data, "");

            while (Data.Contains("  "))
            {
                Data = Regex.Replace(Data, "  ", " ");
            }

            return Data;
        }

        public static String Alpha(String Data)
        {
            Regex RegEx = new Regex(@"[^a-zA-Z]");
            Data = RegEx.Replace(Data, "");

            while (Data.Contains("  "))
            {
                Data = Regex.Replace(Data, "  ", " ");
            }

            return Data;
        }

        public static String Numeric(String Data)
        {
            Regex RegEx = new Regex(@"[^0-9]");
            Data = RegEx.Replace(Data, "");

            while (Data.Contains("  "))
            {
                Data = Regex.Replace(Data, "  ", " ");
            }

            return Data;
        }

        public static List<String> Chunk(String Data, int Size)
        {
            List<String> List = new List<String>();

            Data = Printable(Data);

            for (int I = 0; I < Data.Length; I += Size)
                List.Add(Data.Substring(I, Math.Min(Size, Data.Length - I)).Trim());

            return List;
        }
    }
}
