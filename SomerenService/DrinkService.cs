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
            return drinkDao.GetAllDrinks();
        }
    }
}
