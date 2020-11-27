using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class Dao
    {
        public static TransactionDao Transaction { get; } = new TransactionDao();
        public static ResourceQuoteDao ResourceQuote { get; } = new ResourceQuoteDao();
        public static EmployeeDao Employee { get; } = new EmployeeDao();
        public static ResourceDao Resource { get; } = new ResourceDao();
        public static WareHouseDao WhereHouse { get; } = new WareHouseDao();
        public static OrderDao Order { get; } = new OrderDao();
    }
}
