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
        public DataGrid dataGridView1;

        public static void SaveDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Write headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sb.Append(EscapeCsvField(dgv.Columns[i].HeaderText));
                    if (i < dgv.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();

                // Write rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the empty "new row" at the bottom

                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString() ?? "";
                        sb.Append(EscapeCsvField(cellValue));
                        if (i < dgv.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving CSV file:\n{ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to handle commas, quotes, and newlines in CSV fields
        public static string EscapeCsvField(string field)
        {
            if (field == null) return "";
            if (field.Contains(',') || field.Contains('"') || field.Contains('\n') || field.Contains('\r'))
            {
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }
            return field;
        }

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
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        if (lines.Length == 0) return new DataTable();

                        DataTable dt = new DataTable();
                        string[] headers = lines[0].Split(',');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header.Trim());
                        }

                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] fields = lines[i].Split(new char[] { ',' }, StringSplitOptions.None);

                            // 🔧 Critical fix: ensure fields length matches columns
                            Array.Resize(ref fields, dt.Columns.Count); // pads with null if too short, truncates if too long

                            // Convert nulls to empty strings for safety
                            for (int j = 0; j < fields.Length; j++)
                            {
                                fields[j] = fields[j]?.Trim() ?? "";
                            }

                            dt.Rows.Add(fields);
                        }

                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading CSV:\n{ex.Message}", "Load Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new DataTable();
                    }
                }
            }
            return new DataTable();
        }


    }




}

