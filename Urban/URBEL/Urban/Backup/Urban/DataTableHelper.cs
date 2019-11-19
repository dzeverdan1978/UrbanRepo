using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace Urban
{
    public class DataTableHelper
    {
        public static void ProduceCSV(DataTable dt, System.IO.TextWriter httpStream, bool WriteHeader)
        {
            if (WriteHeader)
            {
                string[] arr = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    arr[i] = dt.Columns[i].ColumnName;
                    arr[i] = GetWriteableValue(arr[i]);
                }

                httpStream.WriteLine(string.Join(",", arr));
            }

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string[] dataArr = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    object o = dt.Rows[j][i];
                    dataArr[i] = GetWriteableValue(o);
                }
                httpStream.WriteLine(string.Join(",", dataArr));
            }
        }

        #region CSV Producer
        public static void ProduceCSV(DataTable dt, System.IO.StreamWriter file, bool WriteHeader)
        {
            if (WriteHeader)
            {
                string[] arr = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    arr[i] = dt.Columns[i].ColumnName;
                    arr[i] = GetWriteableValue(arr[i]);
                }

                file.WriteLine(string.Join(",", arr));
            }

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                string[] dataArr = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    object o = dt.Rows[j][i];
                    dataArr[i] = GetWriteableValue(o);
                }
                file.WriteLine(string.Join(",", dataArr));
            }
        }

        public static string GetWriteableValue(object o)
        {
            if (o == null || o == Convert.DBNull)
                return "";
            else if (o.ToString().IndexOf(",") == -1)
                return o.ToString();
            else
                return "\"" + o.ToString() + "\"";

        }
        #endregion
    }
}
