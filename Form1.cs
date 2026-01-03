using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Corporate_Financial_Statement_Analyzer
{
    public partial class Form1 : Form
    {
        // Declare all content panels
        private Panel mainPanel;           // 👈 Added this missing field
        private Panel benchmarkingPanel;
        private Panel editorPanel;
        private Panel aboutPanel;
        private Panel loginPanel;
        private Panel contentContainer;

        // Current active panel
        private Panel currentActivePanel;

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

        // Event handlers (keeping your existing empty ones)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
        private void button1_Click(object sender, EventArgs e) {}
        private void panel1_Paint(object sender, PaintEventArgs e) {}
        private void iconPictureBox1_Click(object sender, EventArgs e) {}
        private void pictureBox1_Click_1(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {}
        private void _CashFlowSave_Click(object sender, EventArgs e) {}
        private void panel1_Paint_1(object sender, PaintEventArgs e) {}
        private void panel1_Paint_2(object sender, PaintEventArgs e) {}
        private void AboutButton_Paint(object sender, PaintEventArgs e) {}

        public Form1()
        {
            InitializeComponent();
            
            // Initialize left border indicator
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40); // height will be set dynamically
            leftBorderBtn.BackColor = Color.FromArgb(172, 126, 241);
            panelMenu.Controls.Add(leftBorderBtn);
            leftBorderBtn.Visible = false;

            // Create the main content container
            contentContainer = new Panel();
            contentContainer.Dock = DockStyle.Fill;
            contentContainer.BackColor = Color.FromArgb(37, 36, 81);
            this.Controls.Add(contentContainer); // Add to form, AFTER sidebar

            // Initialize all content panels
            InitializeContentPanels();
        }

        private void InitializeContentPanels()
        {
            // Main panel
            ////mainPanel = new Panel();
            //mainPanel.Dock = DockStyle.Fill;
            //mainPanel.BackColor = Color.FromArgb(37, 36, 81);
            contentContainer.Controls.Add(mainPanel);

            // Benchmarking panel
            benchmarkingPanel = new Panel();
            benchmarkingPanel.Dock = DockStyle.Fill;
            benchmarkingPanel.BackColor = Color.FromArgb(37, 36, 81);
            benchmarkingPanel.Visible = false;
            contentContainer.Controls.Add(benchmarkingPanel);

            // Editor panel
            editorPanel = new Panel();
            editorPanel.Dock = DockStyle.Fill;
            editorPanel.BackColor = Color.FromArgb(37, 36, 81);
            editorPanel.Visible = false;
            contentContainer.Controls.Add(editorPanel);

            // About panel
            aboutPanel = new Panel();
            aboutPanel.Dock = DockStyle.Fill;
            aboutPanel.BackColor = Color.FromArgb(37, 36, 81);
            aboutPanel.Visible = false;
            contentContainer.Controls.Add(aboutPanel);

            // Login panel
            loginPanel = new Panel();
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.BackColor = Color.FromArgb(37, 36, 81);
            loginPanel.Visible = false;
            contentContainer.Controls.Add(loginPanel);

            // Initial state
            ShowPanel(mainPanel);
            currentActivePanel = mainPanel;
        }

        private void ShowPanel(Panel panelToShow)
        {
            if (currentActivePanel != null)
                currentActivePanel.Visible = false;
            
            panelToShow.Visible = true;
            currentActivePanel = panelToShow;
        }

        // CSV Loading Methods
        private void button2_Click(object sender, EventArgs e)
        {
            CSVLoader loader = new CSVLoader();
            var data = loader.buttonClick_LoadCSV();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.ClearSelection();

        }

        private void _incomeStatmentSave_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "Save Edited Financial Data";
                sfd.FileName = "edited_financials.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Assuming your DataGridView is named 'dataGridView1'
                    CSVLoader.SaveDataGridViewToCSV(dataGridView1, sfd.FileName);
                }
            }
        }
        private void _IncomStatmentCSV_Click(object sender, EventArgs e)
        {
            CSVLoader loader = new CSVLoader();
            var data = loader.buttonClick_LoadCSV();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.ClearSelection();

        }

        private void _CashFlowCSV_Click(object sender, EventArgs e)
        {
            CSVLoader loader = new CSVLoader();
            var data = loader.buttonClick_LoadCSV();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.ClearSelection();

        }

        // Button Styling Methods
        private void ActivateButton(object senderBut, Color color)
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

        private void DisableAndEnableButtons(object sender, Color color)
        {
            if (!(sender is IconButton clickedBtn)) return;

            if (currentBtn != clickedBtn)
            {
                DisableButton();
                ActivateButton(clickedBtn, color);
            }
            else
            {
                DisableButton();
                currentBtn = null;
            }
        }

        // Sidebar Button Click Handlers
        private void MainButton_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color1);
            ShowPanel(mainPanel);
            //mainPanel.Visible = true;


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color2);
            ShowPanel(benchmarkingPanel);
            
            if (benchmarkingPanel.Controls.Count == 0)
            {
                AddBenchmarkingContent();
            }
        }

        //private void iconButton4_Click(object sender, EventArgs e)
        //{
        //    DisableAndEnableButtons(sender, RGBColors.color3);
        //    ShowPanel(editorPanel);
            
        //    if (editorPanel.Controls.Count == 0)
        //    {
        //        AddEditorContent();
        //    }
        //}

        private void AboutButton_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color4);
            ShowPanel(aboutPanel);
            
            if (aboutPanel.Controls.Count == 0)
            {
                AddAboutContent();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DisableAndEnableButtons(sender, RGBColors.color5);
            ShowPanel(loginPanel);
            
            if (loginPanel.Controls.Count == 0)
            {
                AddLoginContent();
            }
        }

        // Content Initialization Methods
        private void AddBenchmarkingContent()
        {
            Label lblBenchmarking = new Label();
            lblBenchmarking.Text = "Benchmarking Section";
            lblBenchmarking.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblBenchmarking.ForeColor = Color.White;
            lblBenchmarking.Location = new Point(555, 20);
            lblBenchmarking.AutoSize = true;

            Label lblDescription = new Label();
            lblDescription.Text = "This section allows you to compare financial statements against industry benchmarks.";
            lblDescription.ForeColor = Color.LightGray;
            lblDescription.Location = new Point(475, 60);
            lblDescription.Size = new Size(400, 60);
            lblDescription.AutoSize = false; // ✅ Enables text wrapping
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;

            Button btnLoadData = new Button();
            btnLoadData.Text = "Load Benchmark Data";
            btnLoadData.Location = new Point(593, 130);
            btnLoadData.Size = new Size(150, 30);
            btnLoadData.Click += (s, e) => {
                MessageBox.Show("Loading benchmark data...");///make it open a file dialog to load benchmark data 
            };

            benchmarkingPanel.Controls.Add(lblBenchmarking);
            benchmarkingPanel.Controls.Add(lblDescription);
            benchmarkingPanel.Controls.Add(btnLoadData);
        }

        //private void AddEditorContent()
        //{
        //    Label lblEditor = new Label();
        //    lblEditor.Text = "Editor Section";
        //    lblEditor.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        //    lblEditor.ForeColor = Color.White;
        //    lblEditor.Location = new Point(550, 20);
        //    lblEditor.AutoSize = true;

        //    Label lblDescription = new Label();
        //    lblDescription.Text = "Edit and modify your financial statements here.";
        //    lblDescription.ForeColor = Color.LightGray;
        //    lblDescription.Location = new Point(520, 60);
        //    lblDescription.Size = new Size(400, 60);
        //    lblDescription.AutoSize = false; 
        //    lblDescription.TextAlign = ContentAlignment.TopLeft;

        //    Button btnEditBalanceSheet = new Button();
        //    btnEditBalanceSheet.Text = "Edit Balance Sheet";
        //    btnEditBalanceSheet.Location = new Point(550, 130);
        //    btnEditBalanceSheet.Size = new Size(150, 30);
        //    btnEditBalanceSheet.Click += (s, e) => {
        //        MessageBox.Show("Opening balance sheet editor...");
        //    };

        //    Button btnEditIncomeStatement = new Button();
        //    btnEditIncomeStatement.Text = "Edit Income Statement";
        //    btnEditIncomeStatement.Location = new Point(550, 170);
        //    btnEditIncomeStatement.Size = new Size(150, 30);
        //    btnEditIncomeStatement.Click += (s, e) => {
        //        MessageBox.Show("Opening income statement editor...");
        //    };

        //    editorPanel.Controls.Add(lblEditor);
        //    editorPanel.Controls.Add(lblDescription);
        //    editorPanel.Controls.Add(btnEditBalanceSheet);
        //    editorPanel.Controls.Add(btnEditIncomeStatement);
        //}

        private void AddAboutContent()
        {
            Label lblAbout = new Label();
            lblAbout.Text = "About This Application";
            lblAbout.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblAbout.ForeColor = Color.White;
            lblAbout.TextAlign = ContentAlignment.MiddleLeft;
            lblAbout.Location = new Point(530, 30);
            lblAbout.AutoSize = true;

            Label lblDescription = new Label();
            lblDescription.Text = @"Corporate Financial Statement Analyzer v1.0

Developed by Fast Path

This application helps analyze corporate financial statements including:
- Balance Sheets
- Income Statements  
- Cash Flow Statements";
            lblDescription.ForeColor = Color.LightGray;
            lblDescription.Location = new Point(500, 70);

            lblDescription.Size = new Size(300, 300);
            lblDescription.AutoSize = false;
            lblDescription.Font = new Font("Segoe UI" , 12 , FontStyle.Regular);
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;

            Button btnWebsite = new Button();
            btnWebsite.Text = "Visit Our Website";
            btnWebsite.Location = new Point(575,390);
            btnWebsite.Size = new Size(150, 30);
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = "https://yosefther.github.io/FastPathPortfolio/";
            btnWebsite.Click += (s, e) => {
                try 
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://yosefther.github.io/FastPathPortfolio/",
                        UseShellExecute = true
                    });
                }
                catch { MessageBox.Show("Could not open website."); }
            };

            aboutPanel.Controls.Add(lblAbout);
            aboutPanel.Controls.Add(lblDescription);
            aboutPanel.Controls.Add(btnWebsite);
        }

        private void AddLoginContent()
        {
            Label lblLogin = new Label();
            lblLogin.Text = "Login";
            lblLogin.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(500, 20);
            lblLogin.AutoSize = true;

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.ForeColor = Color.LightGray;
            lblUsername.Location = new Point(400, 60);
            lblUsername.AutoSize = true;

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(500, 60);
            txtUsername.Size = new Size(200, 20);

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.ForeColor = Color.LightGray;
            lblPassword.Location = new Point(400, 90);
            lblPassword.AutoSize = true;

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(500, 90);
            txtPassword.Size = new Size(200, 20);
            txtPassword.PasswordChar = '*';

            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(500, 130);
            btnLogin.Size = new Size(100, 30);
            btnLogin.Click += (s, e) => {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }
                MessageBox.Show($"Welcome, {txtUsername.Text}!");
            };

            Button btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Location = new Point(610, 130);
            btnRegister.Size = new Size(100, 30);
            btnRegister.Click += (s, e) => {
                MessageBox.Show("Registration feature coming soon!");
            };

            loginPanel.Controls.Add(lblLogin);
            loginPanel.Controls.Add(lblUsername);
            loginPanel.Controls.Add(txtUsername);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(btnRegister);
        }
    }
}