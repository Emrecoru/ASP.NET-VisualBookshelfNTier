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
    public class BookLanguageConfiguration : IEntityTypeConfiguration<BookLanguage>
    {
        public void Configure(EntityTypeBuilder<BookLanguage> builder)
        {
            builder.HasIndex(x => new
            {
                x.LanguageId,
                x.BookId
            }).IsUnique();

            builder.HasOne(x => x.Book).WithMany(x => x.BookLanguages).HasForeignKey(x => x.BookId);
            builder.HasOne(x => x.Language).WithMany(x => x.BookLanguages).HasForeignKey(x => x.LanguageId);
        }
    }
}
