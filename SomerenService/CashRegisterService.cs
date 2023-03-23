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

        public int GetSales(DateTime startDate, DateTime endDate)
        {
            int sales = cashRegisterdb.GetSales(startDate,endDate);
            return sales;
        }

        public double GetTurnover(DateTime startDate, DateTime endDate)
        {
            double turnover = cashRegisterdb.GetTurnover(startDate,endDate); ;
            return turnover;
        }

        public int GetTotalCustomers(DateTime startDate, DateTime endDate)
        {
            int nrOfCustomers = cashRegisterdb.GetTotalCustomers(startDate,endDate);
            return nrOfCustomers;
        }
    }
}
