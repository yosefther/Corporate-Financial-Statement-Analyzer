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
        private DataGrid dataGridView1;

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
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    MessageBox.Show("File or directory not found: " + ex.Message);
                }
                else if (ex is IOException)
                {
                    MessageBox.Show("I/O error occurred: " + ex.Message);
                }
                else {
                    MessageBox.Show("Error loading CSV file: " + ex.Message); }
                return null;
            }
        }
        public DataTable buttonClick_LoadCSV()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    string[] lines = File.ReadAllLines(ofd.FileName);

                    if (lines.Length == 0) return dt;

                    // Add columns from header
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header.Trim(), typeof(string)); // or parse type
                    }

                    // Add rows
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(new char[] { ',' }, StringSplitOptions.None);
                        dt.Rows.Add(fields);
                    }

                    return dt;
                }
            }
            return new DataTable();
        }


        public static void SaveDataGridViewToCSV(string path)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                //add to the save button 
            }
        }


        //public void LoadCSV(string fileType)
        //{
        //    CSVLoader loader = new CSVLoader();
        //    switch (fileType)
        //    {
        //        case "BalanceSheet":
        //            dataGridView1.DataSource = loader.LoadBalanceSheetCSV();
        //            break;
        //        case "IncomeStatement":
        //            dataGridView1.DataSource = loader.LoadIncomeStatementCSV();
        //            break;
        //        case "CashFlow":
        //            dataGridView1.DataSource = loader.LoadCashFlowCSV();
        //            break;
        //    }
        //}

    }




}

