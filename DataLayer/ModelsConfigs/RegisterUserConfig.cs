using Entities.Models.Request.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ModelsConfigs
{
    internal class RegisterUserConfig : IEntityTypeConfiguration<RegisterUser>
    {
        public void Configure(EntityTypeBuilder<RegisterUser> builder)
        {
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x=>x.LastName).IsRequired();
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.CompanyName).IsRequired();
            builder.Property(x=>x.PhoneNumber).IsRequired();

        }
    }
}
