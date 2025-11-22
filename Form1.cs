using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Corporate_Financial_Statement_Analyzer
{
    public partial class Form1 : Form
    {
        private DataTable currentTable;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void importCsvButtonClick(object sender, EventArgs e)
        {

        }

        private void ManualEntryButton_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void _IncomStatmentCSV_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                // Load and process the CSV file as needed
            }
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    string path = ofd.FileName;
                    currentTable = LoadCsvToDataTable(path);
                    dataGridView1.DataSource = currentTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Simple CSV reader into DataTable
        private DataTable LoadCsvToDataTable(string filePath)
        {
            var dt = new DataTable();
            // Read all lines
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            if (lines.Length == 0) return dt;

            // Parse header
            string[] headers = ParseCsvLine(lines[0]);
            foreach (var h in headers)
                dt.Columns.Add(h);

            // Parse remaining lines
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = ParseCsvLine(lines[i]);

                // If row has different field count, expand columns or fill missing
                if (fields.Length > dt.Columns.Count)
                {
                    int extra = fields.Length - dt.Columns.Count;
                    for (int j = 0; j < extra; j++) dt.Columns.Add($"Column{dt.Columns.Count + 1}");
                }

                var row = dt.NewRow();
                for (int c = 0; c < fields.Length; c++) row[c] = fields[c];
                dt.Rows.Add(row);
            }

            return dt;
        }

        private string[] ParseCsvLine(string line)
        {
            if (line == null) return new string[0];

            var fields = new System.Collections.Generic.List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (inQuotes)
                {
                    if (ch == '"')
                    {
                        // If next char is also a quote, it's an escaped quote
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            sb.Append('"');
                            i++; // skip second quote
                        }
                        else
                        {
                            inQuotes = false; // end quote
                        }
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
                else
                {
                    if (ch == '"')
                    {
                        inQuotes = true;
                    }
                    else if (ch == ',')
                    {
                        fields.Add(sb.ToString());
                        sb.Clear();
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
            }

            fields.Add(sb.ToString()); // last field
            return fields.ToArray();
        }

    }
}
