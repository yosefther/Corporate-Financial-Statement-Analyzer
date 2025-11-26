using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Financial_Statement_Analyzer
{

    public class IncomeStatementProcessor
    {

        public decimal GrossProfit { get; set; }
        public decimal OperatingIncome { get; set; }
        public decimal PreTaxIncome { get; set; }
        public decimal Taxes { get; set; }
        public decimal NetIncome { get; set; }

        private readonly DataTable _dataTable;
        private readonly int _numberOfYears;

        public IncomeStatementProcessor(DataTable dataTable, int numberOfYears)
        {
            _dataTable = dataTable ?? throw new ArgumentNullException(nameof(dataTable));

            if (numberOfYears <= 0)
                throw new ArgumentException("Number of years must be positive", nameof(numberOfYears));

            _numberOfYears = numberOfYears;
        }

        public IncomeStatementResult CalculateIncomeStatement(FinancialData data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            ValidateFinancialData(data);

            return new IncomeStatementResult
            {
                GrossProfit = CalculateGrossProfit(data.Revenue, data.COGS),
                OperatingIncome = CalculateOperatingIncome(data.Revenue, data.COGS, data.OperatingExpenses),
                PreTaxIncome = CalculatePreTaxIncome(data.Revenue, data.COGS, data.OperatingExpenses, data.InterestExpense),
                Taxes = CalculateTaxes(data.Revenue, data.COGS, data.OperatingExpenses, data.InterestExpense, data.TaxRate),
                NetIncome = CalculateNetIncome(data.Revenue, data.COGS, data.OperatingExpenses, data.InterestExpense, data.TaxRate)
            };
        }

        private decimal CalculateGrossProfit(decimal revenue, decimal cogs)
        {
            ValidatePositiveValues(revenue, nameof(revenue));
            ValidateNonNegativeValues(cogs, nameof(cogs));

            return revenue - cogs;
        }

        private decimal CalculateOperatingIncome(decimal revenue, decimal cogs, decimal operatingExpenses)
        {
            return CalculateGrossProfit(revenue, cogs) - operatingExpenses;
        }

        private decimal CalculatePreTaxIncome(decimal revenue, decimal cogs, decimal operatingExpenses, decimal interestExpense)
        {
            return CalculateOperatingIncome(revenue, cogs, operatingExpenses) - interestExpense;
        }

        private decimal CalculateTaxes(decimal revenue, decimal cogs, decimal operatingExpenses,
                                      decimal interestExpense, decimal taxRate)
        {
            if (taxRate < 0 || taxRate > 1)
                throw new ArgumentException("Tax rate must be between 0 and 1", nameof(taxRate));

            var preTaxIncome = CalculatePreTaxIncome(revenue, cogs, operatingExpenses, interestExpense);
            return preTaxIncome * taxRate;
        }

        private decimal CalculateNetIncome(decimal revenue, decimal cogs, decimal operatingExpenses,
                                         decimal interestExpense, decimal taxRate)
        {
            var preTaxIncome = CalculatePreTaxIncome(revenue, cogs, operatingExpenses, interestExpense);
            var taxes = CalculateTaxes(revenue, cogs, operatingExpenses, interestExpense, taxRate);
            return preTaxIncome - taxes;
        }

        private void ValidateFinancialData(FinancialData data)
        {
            ValidatePositiveValues(data.Revenue, nameof(data.Revenue));
            ValidateNonNegativeValues(data.COGS, nameof(data.COGS));
            ValidateNonNegativeValues(data.OperatingExpenses, nameof(data.OperatingExpenses));
            ValidateNonNegativeValues(data.InterestExpense, nameof(data.InterestExpense));

            if (data.TaxRate < 0 || data.TaxRate > 1)
                throw new ArgumentException("Tax rate must be between 0 and 1", nameof(data.TaxRate));
        }

        private void ValidatePositiveValues(decimal value, string paramName)
        {
            if (value <= 0)
                throw new ArgumentException($"{paramName} must be positive", paramName);
        }

        private void ValidateNonNegativeValues(decimal value, string paramName)
        {
            if (value < 0)
                throw new ArgumentException($"{paramName} cannot be negative", paramName);
        }

        public List<IncomeStatementResult> ProcessHistoricalData()
        {
            var results = new List<IncomeStatementResult>();

            foreach (DataRow row in _dataTable.Rows)
            {
                var data = new FinancialData
                {
                    Revenue = Convert.ToDecimal(row["Revenue"]),
                    COGS = Convert.ToDecimal(row["COGS"]),
                    OperatingExpenses = Convert.ToDecimal(row["OperatingExpenses"]),
                    InterestExpense = Convert.ToDecimal(row["InterestExpense"]),
                    TaxRate = Convert.ToDecimal(row["TaxRate"])
                };

                results.Add(CalculateIncomeStatement(data));
            }

            return results;
        }
    }
}