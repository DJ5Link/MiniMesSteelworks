using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class EmployeeDao : SingleKeyDao<Employee, int>
    {
        protected override Expression<Func<Employee, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Employee, bool>> IsKey(int key)
        {
            return x => x.EmployeeId == key;
        }

        public bool VerifyIdPassword(string id, string passwd)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            where x.EmployeeId.ToString() == id && x.Password == passwd
                            select x;

                List<Employee> list = query.ToList();
                if ( list.Count() == 1 )
                    return true;

                return false;
            }
        }
    }
}
