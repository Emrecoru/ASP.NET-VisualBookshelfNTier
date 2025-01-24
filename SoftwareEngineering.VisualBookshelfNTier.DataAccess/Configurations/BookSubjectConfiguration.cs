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
    public class BookSubjectConfiguration : IEntityTypeConfiguration<BookSubject>
    {
        public void Configure(EntityTypeBuilder<BookSubject> builder)
        {
            builder.HasIndex(x => new
            {
                x.SubjectId,
                x.BookId
            }).IsUnique();

            builder.HasOne(x => x.Book).WithMany(x => x.BookSubjects).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Subject).WithMany(x => x.BookSubjects).HasForeignKey(x => x.SubjectId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
