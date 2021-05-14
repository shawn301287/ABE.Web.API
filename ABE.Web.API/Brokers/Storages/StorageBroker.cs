using ABE.Web.API.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABE.Web.API.Brokers.Storages
{
    public class StorageBroker : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>, IStorageBroker
    {
        public readonly IConfiguration configuration;



        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            // this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = this.configuration.GetConnectionString("ABE-COM143");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
