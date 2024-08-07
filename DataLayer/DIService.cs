using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DIService
    {
        public static IServiceCollection AddDatabaseService(this IServiceCollection services , IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");

            //for Entity Framwork
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            //for Ientity : AspNetCore.Identity Framework
            services.AddIdentity<IdentityUser,IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //adding Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }
            );
            return services;
        }
    }
}
