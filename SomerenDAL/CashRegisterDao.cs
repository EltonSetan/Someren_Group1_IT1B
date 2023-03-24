using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        public List<CashRegister> GetAllCashRegister()
        {
            string query = "SELECT DrinkId, DrinkName, isAlcoholic, Stock, PriceOfDrink FROM [Drink]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<CashRegister> ReadTables(DataTable dataTable)
        {
            List<CashRegister> cashRegister = new List<CashRegister>();

            foreach (DataRow dr in dataTable.Rows)
            {
                CashRegister cashregister = new CashRegister()
                {
                    Id = (int)dr["DrinkId"],
                    Name = (string)dr["DrinkName"],
                    Alcoholic = (string)dr["isAlcoholic"],
                    Stock = (int)dr["Stock"],
                    Price = (double)dr["PriceOfDrink"],
                };
                cashRegister.Add(cashregister);
            }
            return cashRegister;
        }

        public void InsertSale(int studentId, int drinkId, double amountPaid)
        {
            string query = "INSERT INTO [CashRegister] (StudentId, DrinkId, DateOfSale, PriceOfDrink) VALUES (@studentId, @drinkId, @date, @amountPaid)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@studentId", studentId),
        new SqlParameter("@drinkId", drinkId),
        new SqlParameter("@date", DateTime.Now),
        new SqlParameter("@amountPaid", amountPaid)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddSale(int studentId, int drinkId)
        {
            int nextSalesId = GetNextSalesId();

            string query = "INSERT INTO CashRegister (SalesId, StudentId, DrinkId, DateOfSale) VALUES (@salesId, @studentId, @drinkId, @dateOfSale)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@salesId", SqlDbType.Int) { Value = nextSalesId },
        new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId },
        new SqlParameter("@drinkId", SqlDbType.Int) { Value = drinkId },
        new SqlParameter("@dateOfSale", SqlDbType.DateTime) { Value = DateTime.Now }
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private int GetNextSalesId()
        {
            string query = "SELECT MAX(SalesId) FROM CashRegister";

            DataTable result = ExecuteSelectQuery(query, new SqlParameter[0]);

            if (result.Rows.Count > 0 && !DBNull.Value.Equals(result.Rows[0][0]))
            {
                return Convert.ToInt32(result.Rows[0][0]) + 1;
            }

            return 1;
        }


    }
}