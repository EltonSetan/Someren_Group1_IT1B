using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinksWithSales()
        {
            string query = @"SELECT d.DrinkId, d.DrinkName, d.PriceOfDrink, d.isAlcoholic, d.Stock, COUNT(cr.StudentId) as times_sold
                     FROM dbo.Drink d
                     LEFT JOIN dbo.CashRegister cr ON d.DrinkId = cr.DrinkId
                     GROUP BY d.DrinkId, d.DrinkName, d.PriceOfDrink, d.isAlcoholic, d.Stock
                     ORDER BY d.DrinkName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Drink> ReadDrinks(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    drinkId = (int)dr["drinkId"],
                    drinkName = (string)dr["DrinkName"],
                    drinkPrice = (double)dr["PriceOfDrink"],
                    isAlcoholic = (string)dr["isAlcoholic"],
                    Stock = (int)dr["Stock"],
                    TimesSold = (int)dr["times_sold"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void AddDrink(Drink drink)
        {
            string query = @"INSERT INTO dbo.Drink (DrinkId, DrinkName, PriceOfDrink, isAlcoholic, Stock)
                 VALUES (@DrinkId, @DrinkName, @PriceOfDrink, @isAlcoholic, @Stock)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@DrinkId", drink.drinkId),
        new SqlParameter("@DrinkName", drink.drinkName),
        new SqlParameter("@PriceOfDrink", drink.drinkPrice),
        new SqlParameter("@isAlcoholic", drink.isAlcoholic),
        new SqlParameter("@Stock", drink.Stock)
            };
            ExecuteEditQuery(query, sqlParameters);
        }


        public void RemoveDrink(int drinkId)
        {
            string query = @"DELETE FROM dbo.Drink WHERE DrinkId = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@DrinkId", drinkId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrink(Drink drink)
        {
            string query = @"UPDATE dbo.Drink
                     SET DrinkName = @DrinkName, PriceOfDrink = @PriceOfDrink, isAlcoholic = @isAlcoholic, Stock = @Stock
                     WHERE DrinkId = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@DrinkId", drink.drinkId),
        new SqlParameter("@DrinkName", drink.drinkName),
        new SqlParameter("@PriceOfDrink", drink.drinkPrice),
        new SqlParameter("@isAlcoholic", drink.isAlcoholic),
        new SqlParameter("@Stock", drink.Stock)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetNextDrinkId()
        {
            int maxDrinkId = 0;
            string query = "SELECT MAX(DrinkId) FROM Drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
            {
                maxDrinkId = Convert.ToInt32(dataTable.Rows[0][0]);
            }
            return maxDrinkId + 1;
        }

    }
}
