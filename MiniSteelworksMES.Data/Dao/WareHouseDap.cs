using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class WareHouseDao : SingleKeyDao<WareHouse, int>
    {
        protected override Expression<Func<WareHouse, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<WareHouse, bool>> IsKey(int key)
        {
            return x => x.WareHouseId == key;
        }
    }
}
