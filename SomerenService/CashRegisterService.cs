using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class CashRegisterService
    {
        private CashRegisterDao cashRegisterdb;

        public CashRegisterService()
        {
            cashRegisterdb = new CashRegisterDao();
        }

        public List<CashRegister> GetAllSales(DateTime startDate, DateTime endDate)
        {
            List<CashRegister> sales = cashRegisterdb.GetAllSales(startDate,endDate);
            return sales;
        }
    }
}
