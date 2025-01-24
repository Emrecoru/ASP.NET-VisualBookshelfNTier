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
    public class BookshelfConfiguration : IEntityTypeConfiguration<Bookshelf>
    {
        public void Configure(EntityTypeBuilder<Bookshelf> builder)
        {
            builder.HasIndex(x => new
            {
                x.AppUserId,
                x.BookId
            }).IsUnique();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Bookshelves).HasForeignKey(x => x.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Book).WithMany(b => b.Bookshelves).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.Cascade);
        }
    }
    
}
