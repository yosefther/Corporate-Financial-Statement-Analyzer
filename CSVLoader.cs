using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corporate_Financial_Statement_Analyzer
{
    public class CSVLoader{
    
    
        public static DataTable GetDataTableFromCSV(string path)
        {
            DataTable dt = new DataTable();
            using(StreamReader sr = new StreamReader(path))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    dt.Rows.Add(rows);
                }
            }
                    return dt;
        }

        public static void SaveDataGridViewToCSV(string path)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                //add to the save button 
            }
        }

    }




}

