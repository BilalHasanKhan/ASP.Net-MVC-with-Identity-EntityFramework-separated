using IdentityTesting.Entities.Context;
using IdentityTesting.Entities.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Entities
{
    public class IdentityUserStore<TUser> : UserStore<TUser>
        where TUser : IdentityUser
    {
        public IdentityUserStore()
            :base()
        {

        }

        public IdentityUserStore(DbContext context)
            :base(context)
        {

        }
    }
}
