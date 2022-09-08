using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace shurl
{
    internal static class LinkMap
    {
        private static DataTable SQLTable; // Datatable to emulate the SQL table that would be storing the website's data

        /// <summary>
        /// Sets up DataTable if not already initialised. 
        /// </summary>
        public static void InitialiseTable()
        {
            if (SQLTable == null)   // If table is not already initialised then add columns
            {
                SQLTable = new DataTable();
                SQLTable.Columns.Add("LinkID", typeof(int));
                SQLTable.Columns.Add("LongLink", typeof(string));
                SQLTable.Columns.Add("ShortLink", typeof(string));
                SQLTable.Columns.Add("Cookie", typeof(string));
            }
        }

        /// <summary>
        /// Fetches the Long link corresponding to that shortlink code
        /// </summary>
        /// <param name="shortlink">code to be searched in the table</param>
        /// <returns>if found then returns long link, else returns "na"</returns>
        public static string GetLongLink(string shortlink)
        {
            DataRow[] rows = SQLTable.Select("ShortLink = '" + shortlink + "'");
            if (rows.Length > 0)
            {
                return rows[0].Field<string>("LongLink");
            }
            else return "na";
        }

        /// <summary>
        /// Fetches the short link corresponding to that longlink if exists, else creates a new link and row in the datatable
        /// </summary>
        /// <param name="longlink">link to be searched for or stored in the datatable against a corresponding code</param>
        /// <returns>shortlink code that was generated or found in table</returns>
        public static string GetShortLink(string longlink)
        {
            DataRow[] rows = SQLTable.Select("LongLink = '" + longlink + "'");
            if (rows.Length > 0)
            {
                return rows[0].Field<string>("ShortLink");  // Link has already been generated
            }
            else  // Generate new link
            {
                int value = SQLTable.Rows.Count;
                //string code = Convert.ToString(value, 16).PadLeft(4,'0');
                string code = EncodeValue(value);
                DataRow newrow = SQLTable.NewRow();
                newrow.SetField("LinkID", value);
                newrow.SetField("LongLink", longlink);
                newrow.SetField("ShortLink", code);
                newrow.SetField("Cookie", "Not implemented"); // Thought for expansion to capture user data and use for customised interface
                SQLTable.Rows.Add(newrow);
                return code;
            }
        }

        private static string EncodeValue(int value)
        {
            // converts value into a 4 digit base 64 representation using the digits below
            char[] Base62map = new char[64]
                { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                'U', 'V', 'W', 'X', 'Y', 'Z', '-', '+'};
            char[] result = { '0', '0', '0', '0' };
            int index = 3;
            while (value > 0)
            {
                int remainder = value % 64;
                result[index] = Base62map[remainder];
                value /= 64;
                index--;
            }
            return string.Join("", result);
        }
    }
}
