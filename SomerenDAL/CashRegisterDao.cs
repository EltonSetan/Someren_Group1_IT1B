﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        public void CheckDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate > DateTime.Now || endDate > DateTime.Now)
            {
                throw new Exception("You can't select a date in the future");
            }
            else if (endDate < startDate)
            {
                throw new Exception("The end date has to be later than the start date");
            }
        }
        //public List<CashRegister> GetAllSales(DateTime startDate, DateTime endDate)
        //{
        //    CheckDateRange(startDate, endDate);

        //    string query = "SELECT StudentId, DrinkId, DateOfSale FROM CashRegister WHERE DateOfSale >= @startDate AND DateOfSale <= @endDate";
        //    SqlParameter[] sqlParameters = new SqlParameter[2];

        //    SqlParameter parameter1 = new SqlParameter();
        //    parameter1.ParameterName = "@startDate";
        //    parameter1.Value = startDate;
        //    sqlParameters[0] = parameter1;

        //    SqlParameter parameter2 = new SqlParameter();
        //    parameter2.ParameterName = "@endDate";
        //    parameter2.Value = endDate;
        //    sqlParameters[1] = parameter2;

        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}
        public int GetSales(DateTime startDate, DateTime endDate)
        {
            CheckDateRange(startDate, endDate);

            string query = "SELECT COUNT(*) AS Sales FROM CashRegister WHERE DateOfSale >= @startDate AND DateOfSale <= @endDate";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };

            DataTable result = ExecuteSelectQuery(query, sqlParameters);
            return (int)result.Rows[0]["Sales"];
        }

        //private List<CashRegister> ReadTables(DataTable dataTable)
        //{
        //    List<CashRegister> sales = new List<CashRegister>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        CashRegister sale = new CashRegister()
        //        {
        //            StudentId = (int)dr["StudentId"],
        //            DrinkId = (int)dr["DrinkId"],
        //            DateOfSale = (DateTime)dr["DateOfSale"]
        //        };
        //        sales.Add(sale);
        //    }
        //    return sales;
        //}

        public double GetTurnover(DateTime startDate, DateTime endDate)
        {
            CheckDateRange(startDate, endDate);

            string query = "SELECT SUM(Drink.PriceOfDrink) AS Turnover FROM CashRegister JOIN Drink ON Drink.DrinkID = CashRegister.DrinkId WHERE DateOfSale >= @startDate AND DateOfSale <= @endDate";
           
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
             };

            DataTable result = ExecuteSelectQuery(query, sqlParameters);
            return (double)result.Rows[0]["Turnover"];
        }

        public int GetTotalCustomers(DateTime startDate, DateTime endDate)
        {
            CheckDateRange(startDate, endDate);

            string query = "SELECT COUNT(DISTINCT StudentId) AS NrOfCustomers FROM CashRegister WHERE DateOfSale >= @startDate AND DateOfSale <= @endDate";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
             };

            DataTable result = ExecuteSelectQuery(query, sqlParameters);
            return (int)result.Rows[0]["NrOfCustomers"];
        }
    }
}

