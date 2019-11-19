using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Urban
{
    public static class Pomocna
    {
        public static void SrediExcel(DataTable tabela)
        {
            foreach (DataRow red in tabela.Rows)
            {
                
                for (int i=0;i<tabela.Columns.Count;i++)
                {
                    
                    if (red[i].GetType()==typeof(String))
                        red[i]=red[i].ToString().Replace(","," ").Replace("\r\n","");
                }
            }
        }
    }
}
