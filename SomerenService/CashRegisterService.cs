using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class CashRegisterService
    {
        private CashRegisterDao drinkdb;

        public CashRegisterService()
        {
            drinkdb = new CashRegisterDao();
        }

        public List<CashRegister> GetCashRegister()
        {
            List<CashRegister> cashregister = drinkdb.GetAllCashRegister();
            return cashregister;
        }

        public void AddSale(int studentId, int drinkId)
        {
            drinkdb.AddSale(studentId, drinkId);
        }
    }
}
