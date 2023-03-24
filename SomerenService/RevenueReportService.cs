using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class RevenueReportService
    {
        private RevenueReportDao revenueReportdb;

        public RevenueReportService()
        {
            revenueReportdb = new RevenueReportDao();
        }

        public int GetSales(DateTime startDate, DateTime endDate)
        {
            int sales = revenueReportdb.GetSales(startDate,endDate);
            return sales;
        }

        public double GetTurnover(DateTime startDate, DateTime endDate)
        {
            double turnover = revenueReportdb.GetTurnover(startDate,endDate); ;
            return turnover;
        }

        public int GetTotalCustomers(DateTime startDate, DateTime endDate)
        {
            int nrOfCustomers = revenueReportdb.GetTotalCustomers(startDate,endDate);
            return nrOfCustomers;
        }
    }
}
