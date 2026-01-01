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
using FontAwesome.Sharp;
using System.Runtime.CompilerServices;

namespace Corporate_Financial_Statement_Analyzer
{
    public partial class Form1 : Form
    {
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void _incomeStatmentSave_Click(object sender, EventArgs e) {}
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e){}
        private void Form1_Load(object sender, EventArgs e) {}
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void iconPictureBox1_Click(object sender, EventArgs e){}
        private void pictureBox1_Click_1(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}



        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Width = 7;
            panelMenu.Controls.Add(leftBorderBtn);

        }

        //todo make the methods below more generic to reduce code duplication 
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
        
       
        private void ActivateButton(object senderBut , Color color)
        {
            if (senderBut != null)
            {
                currentBtn = (IconButton)senderBut;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Height = currentBtn.Height;   
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.Visible = false;
            }
        }

        private void DisableAndEnableButtons(object sender,Color color)
        {
            if (!(sender is IconButton clickedBtn)) return;

            if (currentBtn != clickedBtn)
            {
                DisableButton();                      
                ActivateButton(clickedBtn,color);
            }
            else
            {
                DisableButton();
                currentBtn = null;
            }
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender , RGBColors.color1);
            mainPanel.Visible= true;

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color2);
            //EditorPanel.Visible = true;
            mainPanel.Visible= false;

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color3);
            //EditorPanel.Visible = true;
            mainPanel.Visible= false;
           
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color4);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color5);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _CashFlowSave_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void AboutButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
