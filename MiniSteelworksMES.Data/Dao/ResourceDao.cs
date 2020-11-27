using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class ResourceDao : SingleKeyDao<Resource, int>
    {
        protected override Expression<Func<Resource, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Resource, bool>> IsKey(int key)
        {
            return x => x.ResourceId == key;
        }
    }
}
