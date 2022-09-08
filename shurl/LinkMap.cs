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

        public static string GetLongLink(string shortlink)
        {
            DataRow[] rows = SQLTable.Select("ShortLink = '" + shortlink + "'");
            if (rows.Length > 0)
            {
                return rows[0].Field<string>("LongLink");
            }
            else return "na";
        }

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
                string code = Convert.ToString(value, 16).PadLeft(4,'0');
                DataRow newrow = SQLTable.NewRow();
                newrow.SetField("LinkID", value);
                newrow.SetField("LongLink", longlink);
                newrow.SetField("ShortLink", code);
                newrow.SetField("Cookie", "Not implemented");
                SQLTable.Rows.Add(newrow);
                return code;
            }
        }
    }
}
