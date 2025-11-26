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
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void BtnLoad_Click(object sender, EventArgs e) {}
        private void _incomeStatmentSave_Click(object sender, EventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e) {}
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e){}
        private void Form1_Load(object sender, EventArgs e) {}
        private void importCsvButtonClick(object sender, EventArgs e) {}
        private void ManualEntryButton_Click(object sender, EventArgs e) {}
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e){}


        private void button2_Click(object sender, EventArgs e){
            CSVLoader BalancSheetCSV = new CSVLoader();
            dataGridView1.DataSource = BalancSheetCSV.buttonClick_LoadCSV();
        }

        private void _IncomStatmentCSV_Click(object sender, EventArgs e)
        {
            CSVLoader IncomeCSV = new CSVLoader();
            dataGridView1.DataSource = IncomeCSV.buttonClick_LoadCSV();
        }

        private void _CashFlowCSV_Click(object sender, EventArgs e)
        {
            CSVLoader CashFlowCSV = new CSVLoader();
            dataGridView1.DataSource = CashFlowCSV.buttonClick_LoadCSV();
        }
    }
}
