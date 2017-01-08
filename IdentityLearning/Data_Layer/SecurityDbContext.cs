using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityLearning.Data_Layer
{
    public class SecurityDbContext : DbContext
    {
        public SecurityDbContext() : base("SecurityDb")
        {
        }


    }
}