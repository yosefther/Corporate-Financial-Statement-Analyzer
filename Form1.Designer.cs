using System.Drawing;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Corporate_Financial_Statement_Analyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.AboutButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.BenchmarkingButton = new FontAwesome.Sharp.IconButton();
            this.MainButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._IncomStatmentCSV = new System.Windows.Forms.Button();
            this._BalancSheetCSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._CashFlowCSV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._incomeStatmentSave = new System.Windows.Forms.Button();
            this._BalanceSheetSave = new System.Windows.Forms.Button();
            this._CashFlowSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.AboutButton);
            this.panelMenu.Controls.Add(this.EditButton);
            this.panelMenu.Controls.Add(this.BenchmarkingButton);
            this.panelMenu.Controls.Add(this.MainButton);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(1, -7);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 606);
            this.panelMenu.TabIndex = 10;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AboutButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.AboutButton.IconColor = System.Drawing.Color.LightSteelBlue;
            this.AboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutButton.IconSize = 30;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 317);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(187, 78);
            this.AboutButton.TabIndex = 15;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditButton.IconColor = System.Drawing.Color.LightSteelBlue;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 30;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(0, 236);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(187, 81);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Editor";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // BenchmarkingButton
            // 
            this.BenchmarkingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BenchmarkingButton.FlatAppearance.BorderSize = 0;
            this.BenchmarkingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BenchmarkingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenchmarkingButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BenchmarkingButton.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.BenchmarkingButton.IconColor = System.Drawing.Color.LightSteelBlue;
            this.BenchmarkingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BenchmarkingButton.IconSize = 30;
            this.BenchmarkingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BenchmarkingButton.Location = new System.Drawing.Point(0, 144);
            this.BenchmarkingButton.Name = "BenchmarkingButton";
            this.BenchmarkingButton.Size = new System.Drawing.Size(187, 92);
            this.BenchmarkingButton.TabIndex = 13;
            this.BenchmarkingButton.Text = "Benchmarking";
            this.BenchmarkingButton.UseVisualStyleBackColor = true;
            this.BenchmarkingButton.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // MainButton
            // 
            this.MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MainButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.MainButton.IconColor = System.Drawing.Color.LightSteelBlue;
            this.MainButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MainButton.IconSize = 30;
            this.MainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.Location = new System.Drawing.Point(0, 71);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(187, 73);
            this.MainButton.TabIndex = 12;
            this.MainButton.Text = "Main";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButton1.IconColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 546);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(187, 60);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "login";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 71);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(67, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fast Path";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureBox1.Image = global::Corporate_Financial_Statement_Analyzer.Properties.Resources.شعار_أخضر_مُحدد_رطوش_إنترنت_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-116, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(162, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incom statement ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance sheet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _IncomStatmentCSV
            // 
            this._IncomStatmentCSV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._IncomStatmentCSV.Location = new System.Drawing.Point(251, 125);
            this._IncomStatmentCSV.Name = "_IncomStatmentCSV";
            this._IncomStatmentCSV.Size = new System.Drawing.Size(75, 23);
            this._IncomStatmentCSV.TabIndex = 3;
            this._IncomStatmentCSV.Text = "File.csv";
            this._IncomStatmentCSV.UseVisualStyleBackColor = true;
            this._IncomStatmentCSV.Click += new System.EventHandler(this._IncomStatmentCSV_Click);
            // 
            // _BalancSheetCSV
            // 
            this._BalancSheetCSV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._BalancSheetCSV.Location = new System.Drawing.Point(251, 217);
            this._BalancSheetCSV.Name = "_BalancSheetCSV";
            this._BalancSheetCSV.Size = new System.Drawing.Size(75, 23);
            this._BalancSheetCSV.TabIndex = 4;
            this._BalancSheetCSV.Text = "File.csv";
            this._BalancSheetCSV.UseVisualStyleBackColor = true;
            this._BalancSheetCSV.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cash flow";
            // 
            // _CashFlowCSV
            // 
            this._CashFlowCSV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._CashFlowCSV.Location = new System.Drawing.Point(251, 298);
            this._CashFlowCSV.Name = "_CashFlowCSV";
            this._CashFlowCSV.Size = new System.Drawing.Size(75, 23);
            this._CashFlowCSV.TabIndex = 5;
            this._CashFlowCSV.Text = "File.csv";
            this._CashFlowCSV.UseVisualStyleBackColor = true;
            this._CashFlowCSV.Click += new System.EventHandler(this._CashFlowCSV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(471, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(441, 549);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // _incomeStatmentSave
            // 
            this._incomeStatmentSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._incomeStatmentSave.Location = new System.Drawing.Point(332, 125);
            this._incomeStatmentSave.Name = "_incomeStatmentSave";
            this._incomeStatmentSave.Size = new System.Drawing.Size(75, 23);
            this._incomeStatmentSave.TabIndex = 7;
            this._incomeStatmentSave.Text = "save";
            this._incomeStatmentSave.UseVisualStyleBackColor = true;
            this._incomeStatmentSave.Click += new System.EventHandler(this._incomeStatmentSave_Click);
            // 
            // _BalanceSheetSave
            // 
            this._BalanceSheetSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._BalanceSheetSave.Location = new System.Drawing.Point(332, 217);
            this._BalanceSheetSave.Name = "_BalanceSheetSave";
            this._BalanceSheetSave.Size = new System.Drawing.Size(75, 23);
            this._BalanceSheetSave.TabIndex = 8;
            this._BalanceSheetSave.Text = "save";
            this._BalanceSheetSave.UseVisualStyleBackColor = true;
            // 
            // _CashFlowSave
            // 
            this._CashFlowSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._CashFlowSave.Location = new System.Drawing.Point(332, 298);
            this._CashFlowSave.Name = "_CashFlowSave";
            this._CashFlowSave.Size = new System.Drawing.Size(75, 23);
            this._CashFlowSave.TabIndex = 9;
            this._CashFlowSave.Text = "save";
            this._CashFlowSave.UseVisualStyleBackColor = true;
            this._CashFlowSave.Click += new System.EventHandler(this._CashFlowSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 393);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.checkBox1);
            this.mainPanel.Controls.Add(this._CashFlowSave);
            this.mainPanel.Controls.Add(this._BalanceSheetSave);
            this.mainPanel.Controls.Add(this._incomeStatmentSave);
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this._CashFlowCSV);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this._BalancSheetCSV);
            this.mainPanel.Controls.Add(this._IncomStatmentCSV);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(207, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(915, 555);
            this.mainPanel.TabIndex = 13;
            this.mainPanel.Visible = false;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1149, 593);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Text = "Data import & integration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Panel panelMenu;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton BenchmarkingButton;
        private FontAwesome.Sharp.IconButton MainButton;
        private FontAwesome.Sharp.IconButton AboutButton;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button _IncomStatmentCSV;
        private Button _BalancSheetCSV;
        private Label label2;
        private Button _CashFlowCSV;
        private DataGridView dataGridView1;
        private Button _incomeStatmentSave;
        private Button _BalanceSheetSave;
        private Button _CashFlowSave;
        private CheckBox checkBox1;
        //private Panel mainPanel;
    }
}

