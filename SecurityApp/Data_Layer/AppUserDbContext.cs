using Microsoft.AspNet.Identity.EntityFramework;
using SecurityApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecurityApp.Data_Layer
{
    public class AppUserDbContext : IdentityDbContext<AppUser>
    {
        public AppUserDbContext() : base("SecurityDb") { }

        static AppUserDbContext() {
            Database.SetInitializer<AppUserDbContext>(new IdentityDbInit());
        }

        public static AppUserDbContext Create()
        {
            return new AppUserDbContext();
        }
    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<AppUserDbContext> {
        protected override void Seed(AppUserDbContext context) {
            PerformInitialSetup(context);
            base.Seed(context);
        }

        public void PerformInitialSetup(AppUserDbContext context) {
            // initial configuration will go here
        }
    }
}