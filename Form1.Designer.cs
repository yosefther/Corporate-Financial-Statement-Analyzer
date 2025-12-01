using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._IncomStatmentCSV = new System.Windows.Forms.Button();
            this._BalancSheetCSV = new System.Windows.Forms.Button();
            this._CashFlowCSV = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._incomeStatmentSave = new System.Windows.Forms.Button();
            this._BalanceSheetSave = new System.Windows.Forms.Button();
            this._CashFlowSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MainButton = new FontAwesome.Sharp.IconButton();
            this.BenchmarkingButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.AboutButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(194, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incom statement ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cash flow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance sheet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _IncomStatmentCSV
            // 
            this._IncomStatmentCSV.Location = new System.Drawing.Point(283, 119);
            this._IncomStatmentCSV.Name = "_IncomStatmentCSV";
            this._IncomStatmentCSV.Size = new System.Drawing.Size(75, 23);
            this._IncomStatmentCSV.TabIndex = 3;
            this._IncomStatmentCSV.Text = "File.csv";
            this._IncomStatmentCSV.UseVisualStyleBackColor = true;
            this._IncomStatmentCSV.Click += new System.EventHandler(this._IncomStatmentCSV_Click);
            // 
            // _BalancSheetCSV
            // 
            this._BalancSheetCSV.Location = new System.Drawing.Point(283, 211);
            this._BalancSheetCSV.Name = "_BalancSheetCSV";
            this._BalancSheetCSV.Size = new System.Drawing.Size(75, 23);
            this._BalancSheetCSV.TabIndex = 4;
            this._BalancSheetCSV.Text = "File.csv";
            this._BalancSheetCSV.UseVisualStyleBackColor = true;
            this._BalancSheetCSV.Click += new System.EventHandler(this.button2_Click);
            // 
            // _CashFlowCSV
            // 
            this._CashFlowCSV.Location = new System.Drawing.Point(283, 292);
            this._CashFlowCSV.Name = "_CashFlowCSV";
            this._CashFlowCSV.Size = new System.Drawing.Size(75, 23);
            this._CashFlowCSV.TabIndex = 5;
            this._CashFlowCSV.Text = "File.csv";
            this._CashFlowCSV.UseVisualStyleBackColor = true;
            this._CashFlowCSV.Click += new System.EventHandler(this._CashFlowCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(487, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(301, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // _incomeStatmentSave
            // 
            this._incomeStatmentSave.Location = new System.Drawing.Point(364, 119);
            this._incomeStatmentSave.Name = "_incomeStatmentSave";
            this._incomeStatmentSave.Size = new System.Drawing.Size(75, 23);
            this._incomeStatmentSave.TabIndex = 7;
            this._incomeStatmentSave.Text = "save";
            this._incomeStatmentSave.UseVisualStyleBackColor = true;
            this._incomeStatmentSave.Click += new System.EventHandler(this._incomeStatmentSave_Click);
            // 
            // _BalanceSheetSave
            // 
            this._BalanceSheetSave.Location = new System.Drawing.Point(364, 211);
            this._BalanceSheetSave.Name = "_BalanceSheetSave";
            this._BalanceSheetSave.Size = new System.Drawing.Size(75, 23);
            this._BalanceSheetSave.TabIndex = 8;
            this._BalanceSheetSave.Text = "save";
            this._BalanceSheetSave.UseVisualStyleBackColor = true;
            // 
            // _CashFlowSave
            // 
            this._CashFlowSave.Location = new System.Drawing.Point(364, 292);
            this._CashFlowSave.Name = "_CashFlowSave";
            this._CashFlowSave.Size = new System.Drawing.Size(75, 23);
            this._CashFlowSave.TabIndex = 9;
            this._CashFlowSave.Text = "save";
            this._CashFlowSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.BenchmarkingButton);
            this.panel1.Controls.Add(this.MainButton);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 468);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 112);
            this.panel2.TabIndex = 11;
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
            this.iconButton1.Location = new System.Drawing.Point(0, 408);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(187, 60);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "login";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.MainButton.Location = new System.Drawing.Point(0, 112);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(187, 60);
            this.MainButton.TabIndex = 12;
            this.MainButton.Text = "Main";
            this.MainButton.UseVisualStyleBackColor = true;
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
            this.BenchmarkingButton.Location = new System.Drawing.Point(0, 172);
            this.BenchmarkingButton.Name = "BenchmarkingButton";
            this.BenchmarkingButton.Size = new System.Drawing.Size(187, 60);
            this.BenchmarkingButton.TabIndex = 13;
            this.BenchmarkingButton.Text = "Benchmarking";
            this.BenchmarkingButton.UseVisualStyleBackColor = true;
            this.BenchmarkingButton.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.EditButton.Location = new System.Drawing.Point(0, 232);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(187, 60);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Editor";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.iconButton4_Click);
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
            this.AboutButton.Location = new System.Drawing.Point(0, 292);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(187, 60);
            this.AboutButton.TabIndex = 15;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._CashFlowSave);
            this.Controls.Add(this._BalanceSheetSave);
            this.Controls.Add(this._incomeStatmentSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._CashFlowCSV);
            this.Controls.Add(this._BalancSheetCSV);
            this.Controls.Add(this._IncomStatmentCSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Data import & integration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _IncomStatmentCSV;
        private System.Windows.Forms.Button _BalancSheetCSV;
        private System.Windows.Forms.Button _CashFlowCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button _incomeStatmentSave;
        private System.Windows.Forms.Button _BalanceSheetSave;
        private System.Windows.Forms.Button _CashFlowSave;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton BenchmarkingButton;
        private FontAwesome.Sharp.IconButton MainButton;
        private FontAwesome.Sharp.IconButton AboutButton;
    }
}

