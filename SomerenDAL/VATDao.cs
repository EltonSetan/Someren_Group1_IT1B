using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class VATDao : BaseDao
    {
        public List<int> GetAvailableYears()
        {
            string query = "SELECT DISTINCT YEAR(DateOfSale) AS Year FROM CashRegister ORDER BY Year";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadYears(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<int> ReadYears(DataTable dataTable)
        {
            List<int> years = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                years.Add((int)dr["Year"]);
            }
            return years;
        }

        public (decimal lowTariffTotal, decimal highTariffTotal) GetVATTotals(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT d.isAlcoholic, SUM(d.PriceOfDrink) as TotalSales
                FROM CashRegister c
                JOIN Drink d ON c.DrinkId = d.DrinkId
                WHERE c.DateOfSale >= @startDate AND c.DateOfSale <= @endDate
                GROUP BY d.isAlcoholic
            ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@startDate", SqlDbType.DateTime) { Value = startDate },
                new SqlParameter("@endDate", SqlDbType.DateTime) { Value = endDate },
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            decimal lowTariffTotal = 0;
            decimal highTariffTotal = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string isAlcoholic = row["isAlcoholic"].ToString().ToLower();
                decimal totalSales = Convert.ToDecimal(row["TotalSales"]);
                decimal vatAmount = totalSales * (isAlcoholic == "yes" ? 0.21m : 0.06m);

                if (isAlcoholic == "yes")
                    highTariffTotal += vatAmount;
                else
                    lowTariffTotal += vatAmount;
            }

            return (lowTariffTotal, highTariffTotal);
        }
    }
}
