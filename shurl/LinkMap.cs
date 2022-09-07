using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                SQLTable.Columns.Add("UseCount", typeof(int));
            }
        }

        public static string GetLongLink(string shortlink)
        {
            //ToDo...
            return "Not yet implemented...";
        }

        public static string GetShortLink(string longlink)
        {
            //ToDo...
            return "Not yet implemented...";
        }


    }
}
