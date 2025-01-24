using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.DataAccess.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(30).IsRequired();
            builder.Property(X => X.Username).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
        }
    }
}
