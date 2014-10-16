using IdentityTesting.Entities.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Entities.Context
{
    public class IdentityTestingContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityTestingContext()
            : base("name=DefaultConnection")
        {
        }
    }
}
