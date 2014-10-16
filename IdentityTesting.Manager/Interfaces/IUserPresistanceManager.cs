using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityTesting.Manager.Common;
using IdentityTesting.Entities.Models;

namespace IdentityTesting.Manager
{
    public interface IUserPresistanceManager : IEntityManager<ApplicationUser, string>
    {
        ApplicationUser GetUserByUsername(string username);
    }
}
