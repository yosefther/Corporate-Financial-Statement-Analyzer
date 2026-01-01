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

