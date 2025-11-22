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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incom statement ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cash flow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance sheet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _IncomStatmentCSV
            // 
            this._IncomStatmentCSV.Location = new System.Drawing.Point(126, 84);
            this._IncomStatmentCSV.Name = "_IncomStatmentCSV";
            this._IncomStatmentCSV.Size = new System.Drawing.Size(75, 23);
            this._IncomStatmentCSV.TabIndex = 3;
            this._IncomStatmentCSV.Text = "File.csv";
            this._IncomStatmentCSV.UseVisualStyleBackColor = true;
            this._IncomStatmentCSV.Click += new System.EventHandler(this._IncomStatmentCSV_Click);
            // 
            // _BalancSheetCSV
            // 
            this._BalancSheetCSV.Location = new System.Drawing.Point(126, 177);
            this._BalancSheetCSV.Name = "_BalancSheetCSV";
            this._BalancSheetCSV.Size = new System.Drawing.Size(75, 23);
            this._BalancSheetCSV.TabIndex = 4;
            this._BalancSheetCSV.Text = "File.csv";
            this._BalancSheetCSV.UseVisualStyleBackColor = true;
            this._BalancSheetCSV.Click += new System.EventHandler(this.button2_Click);
            // 
            // _CashFlowCSV
            // 
            this._CashFlowCSV.Location = new System.Drawing.Point(126, 257);
            this._CashFlowCSV.Name = "_CashFlowCSV";
            this._CashFlowCSV.Size = new System.Drawing.Size(75, 23);
            this._CashFlowCSV.TabIndex = 5;
            this._CashFlowCSV.Text = "File.csv";
            this._CashFlowCSV.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(381, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _incomeStatmentSave
            // 
            this._incomeStatmentSave.Location = new System.Drawing.Point(207, 84);
            this._incomeStatmentSave.Name = "_incomeStatmentSave";
            this._incomeStatmentSave.Size = new System.Drawing.Size(75, 23);
            this._incomeStatmentSave.TabIndex = 7;
            this._incomeStatmentSave.Text = "save";
            this._incomeStatmentSave.UseVisualStyleBackColor = true;
            // 
            // _BalanceSheetSave
            // 
            this._BalanceSheetSave.Location = new System.Drawing.Point(207, 177);
            this._BalanceSheetSave.Name = "_BalanceSheetSave";
            this._BalanceSheetSave.Size = new System.Drawing.Size(75, 23);
            this._BalanceSheetSave.TabIndex = 8;
            this._BalanceSheetSave.Text = "save";
            this._BalanceSheetSave.UseVisualStyleBackColor = true;
            // 
            // _CashFlowSave
            // 
            this._CashFlowSave.Location = new System.Drawing.Point(207, 257);
            this._CashFlowSave.Name = "_CashFlowSave";
            this._CashFlowSave.Size = new System.Drawing.Size(75, 23);
            this._CashFlowSave.TabIndex = 9;
            this._CashFlowSave.Text = "save";
            this._CashFlowSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

