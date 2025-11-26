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
            try
            {
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(path))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV file: " + ex.Message);
                return null;
            }
        }
        public DataTable buttonClick_LoadCSV()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DataTable dt = new DataTable();
            ofd.Title = "Select a file";
            ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string FilePath = ofd.FileName;
                dt = CSVLoader.GetDataTableFromCSV(FilePath);
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

