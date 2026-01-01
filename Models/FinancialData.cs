namespace Corporate_Financial_Statement_Analyzer
{
    /// <summary>
    /// Represents financial data for income statement calculations
    /// </summary>
    public class FinancialData
    {
        public decimal Revenue { get; set; }
        public decimal COGS { get; set; }
        public decimal OperatingExpenses { get; set; }
        public decimal InterestExpense { get; set; }
        public decimal TaxRate { get; set; }
    }
}

