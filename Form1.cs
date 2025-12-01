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
using FontAwesome.Sharp;
using System.Runtime.CompilerServices;

namespace Corporate_Financial_Statement_Analyzer
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //leftBorderBtn.contr
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
        private void button1_Click(object sender, EventArgs e){}
        private void iconButton1_Click(object sender, EventArgs e){}
        private void iconButton4_Click(object sender, EventArgs e){}
        private void iconButton3_Click(object sender, EventArgs e){}
        private void AboutButton_Click(object sender, EventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}


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
