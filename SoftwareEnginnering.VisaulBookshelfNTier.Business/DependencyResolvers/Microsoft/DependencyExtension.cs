using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Services;
using SoftwareEngineering.VisaulBookshelfNTier.Business.ValidationRules;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.Contexts;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork;
using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            /*
            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new AuthorProfile());
                opt.AddProfile(new BookProfile());
                opt.AddProfile(new BookAuthorProfile());
                opt.AddProfile(new BookSubjectProfile());
                opt.AddProfile(new BookshelfProfile());
                opt.AddProfile(new SubjectProfile());
                opt.AddProfile(new LanguageProfile());
                opt.AddProfile(new BookTranslatorProfile());
                opt.AddProfile(new TranslatorProfile());
                opt.AddProfile(new BookLanguageProfile());
                opt.AddProfile(new AppUserProfile());
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            */

            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();
            services.AddScoped<IAppUserService, AppUserService>();

            services.AddTransient<IValidator<AuthorCreateDto>, AuthorCreateDtoValidator>();
            services.AddTransient<IValidator<AuthorUpdateDto>, AuthorUpdateDtoValidator>();
            services.AddScoped<IAuthorService, AuthorService>();
            
            services.AddTransient<IValidator<BookCreateDto>, BookCreateDtoValidator>();
            services.AddTransient<IValidator<BookUpdateDto>, BookUpdateDtoValidator>();
            services.AddScoped<IBookService, BookService>();

            services.AddTransient<IValidator<BookAuthorCreateDto>, BookAuthorCreateDtoValidator>();
            services.AddTransient<IValidator<BookAuthorUpdateDto>, BookAuthorUpdateDtoValidator>();
            services.AddScoped<IBookAuthorService, BookAuthorService>();

            services.AddTransient<IValidator<BookSubjectCreateDto>, BookSubjectCreateDtoValidator>();
            services.AddTransient<IValidator<BookSubjectUpdateDto>, BookSubjectUpdateDtoValidator>();
            services.AddScoped<IBookSubjectService, BookSubjectService>();

            services.AddTransient<IValidator<BookshelfCreateDto>, BookshelfCreateDtoValidator>();
            services.AddTransient<IValidator<BookshelfUpdateDto>, BookshelfUpdateDtoValidator>();
            services.AddScoped<IBookshelfService, BookshelfService>();

            services.AddTransient<IValidator<SubjectCreateDto>, SubjectCreateDtoValidator>();
            services.AddTransient<IValidator<SubjectUpdateDto>, SubjectUpdateDtoValidator>();
            services.AddScoped<ISubjectService, SubjectService>();

            services.AddTransient<IValidator<BookTranslatorCreateDto>, BookTranslatorCreateDtoValidator>();
            services.AddTransient<IValidator<BookTranslatorUpdateDto>, BookTranslatorUpdateDtoValidator>();
            

            services.AddTransient<IValidator<TranslatorCreateDto>, TranslatorCreateDtoValidator>();
            services.AddTransient<IValidator<TranslatorUpdateDto>, TranslatorUpdateDtoValidator>();
        }
    }
}
