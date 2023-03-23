using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT id, name, price, is_alcoholic FROM dbo.drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Id = (int)dr["id"],
                    Name = (string)dr["name"],
                    Price = (decimal)dr["price"],
                    IsAlcoholic = (bool)dr["is_alcoholic"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
