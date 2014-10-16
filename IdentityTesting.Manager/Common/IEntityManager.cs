using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Manager.Common
{
    public interface IEntityManager<TEntity, TKey>
        where TEntity : class
        where TKey : class
    {
        TEntity GetByKey(TKey key);
    }
}
