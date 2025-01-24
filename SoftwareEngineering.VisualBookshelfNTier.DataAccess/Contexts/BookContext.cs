using Microsoft.EntityFrameworkCore;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.Configurations;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisualBookshelfNTier.DataAccess.Contexts
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new BookshelfConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new TranslatorConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookTranslatorConfiguration());
            modelBuilder.ApplyConfiguration(new BookSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new BookLanguageConfiguration());

        }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppUserRole> AppUserRoles { get; set; }

        public DbSet<Book> Books{ get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<BookLanguage> BookLanguages { get; set; }

        public DbSet<BookTranslator> BookTranslators { get; set; }

        public DbSet<BookSubject> BookSubjects { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Translator> Translators { get; set; }

        public DbSet<Bookshelf> Bookshelves { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Subject> Subjects { get; set; }


    }
}
