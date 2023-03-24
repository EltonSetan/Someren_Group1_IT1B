using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkDao = new DrinkDao();

        public List<Drink> GetDrinks()
        {
            return drinkDao.GetAllDrinksWithSales();
        }

        public void AddDrink(Drink drink)
        {
            drinkDao.AddDrink(drink);
        }

        public void RemoveDrink(int drinkId)
        {
            drinkDao.RemoveDrink(drinkId);
        }

        public void UpdateDrink(Drink drink)
        {
            drinkDao.UpdateDrink(drink);
        }

        public int GetNextDrinkId()
        {
            DrinkDao drinkDao = new DrinkDao();
            return drinkDao.GetNextDrinkId();
        }
    }

}

