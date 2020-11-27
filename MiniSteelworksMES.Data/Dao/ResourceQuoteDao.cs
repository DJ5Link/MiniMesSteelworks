using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class ResourceQuoteDao : DualKeyDao<ResourceQuote, int, DateTime>
    {
        protected override Expression<Func<ResourceQuote, bool>> IsKey(int key1, DateTime key2)
        {
            return x => x.ResuorceId == key1 && x.Date == key2;
        }
    }
}
