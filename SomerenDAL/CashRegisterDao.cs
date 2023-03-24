using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        public List<CashRegister> GetAllCashRegister()
        {
            string query = "SELECT DrinkId, DrinkName, isAlcoholic, Stock, PriceOfDrink  FROM [Drink]";

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
    }
}