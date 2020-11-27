using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class TransactionDao : TripleKeyDao<Transaction, int, DateTime, int>
    {
        protected override Expression<Func<Transaction, bool>> IsKey(int key1, DateTime key2, int key3)
        {
            return x => x.ResourceId == key1 && x.Date == key2;
        }

        public List<Transaction> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Transactions
                            select x;

                return query.ToList();
            }
        }
    }
}
