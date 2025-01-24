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
    public class BookTranslatorConfiguration : IEntityTypeConfiguration<BookTranslator>
    {
        public void Configure(EntityTypeBuilder<BookTranslator> builder)
        {
            builder.HasIndex(x => new
            {
                x.TranslatorId,
                x.BookId
            }).IsUnique();

            builder.HasOne(x => x.Book).WithMany(x => x.BookTranslators).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Translator).WithMany(x => x.BookTranslators).HasForeignKey(x => x.TranslatorId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
