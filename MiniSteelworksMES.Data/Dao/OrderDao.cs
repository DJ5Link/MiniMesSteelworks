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

        public List<Order> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            select x;

                return query.ToList();
            }
        }

        public List<Order> GetByPK(string orderId)
        {
            orderId.Trim();

            if (orderId == "")
                return null;

            int id = Convert.ToInt32(orderId);

            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            where x.OrderId == id
                            select x;

                return query.ToList();
            }
        }

        public List<Order> GetBySellerName(string sellerName)
        {
            sellerName.Trim();

            if (sellerName == "")
                return null;

            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            where x.SellerName == sellerName
                            select x;

                return query.ToList();
            }
        }
    }
}
