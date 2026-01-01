namespace Corporate_Financial_Statement_Analyzer
{
    /// <summary>
    /// Represents the calculated results of an income statement
    /// </summary>
    public class IncomeStatementResult
    {
        public decimal GrossProfit { get; set; }
        public decimal OperatingIncome { get; set; }
        public decimal PreTaxIncome { get; set; }
        public decimal Taxes { get; set; }
        public decimal NetIncome { get; set; }
    }
}

