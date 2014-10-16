using IdentityTesting.Entities.Context;
using IdentityTesting.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Manager.Implementations
{
    public class UserPresistanceManager : IUserPresistanceManager
    {
        public IdentityTestingContext context { get; set; }
        public UserPresistanceManager()
        {
            context = new IdentityTestingContext();
        }
        public ApplicationUser GetByKey(string key)
        {
            return context.Users.Find(key);
        }
        public ApplicationUser GetUserByUsername(string username)
        {
            return context.Users.SingleOrDefault(u => u.UserName == username);
        }
    }
}
