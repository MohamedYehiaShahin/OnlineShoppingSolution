using DataLayer.ModelsConfigs;
using Entities.Models.Request.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataLayer
{
    public class ApplicationDbContext :IdentityDbContext<RegisterUser>
    {
        public DbSet<RegisterUser> RegisterUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(RegisterUserConfig).Assembly);
        }
    }
}
