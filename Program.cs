using Corporate_Financial_Statement_Analyzer;
using System;
using System.Windows.Forms;

namespace CsvManualSingleScreen
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
