using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class OrderDao : SingleKeyDao<Order, int>
    {
        protected override Expression<Func<Order, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Order, bool>> IsKey(int key)
        {
            return x => x.OrderId == key;
        }
    }
}
