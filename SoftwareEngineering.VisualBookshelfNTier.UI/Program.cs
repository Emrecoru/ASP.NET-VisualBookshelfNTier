using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using SoftwareEngineering.VisaulBookshelfNTier.Business.DependencyResolvers.Microsoft;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Helpers;
using SoftwareEngineering.VisualBookshelfNTier.UI.Mappings.AutoMapper;
using SoftwareEngineering.VisualBookshelfNTier.UI.Models;
using SoftwareEngineering.VisualBookshelfNTier.UI.ValidationRules;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Host.ConfigureServices((hostContext, services) =>
{
    services.AddRazorPages();
    services.AddDependencies(hostContext.Configuration); // Burada direkt IConfiguration nesnesini g�nderiyoruz
    services.AddTransient<IValidator<UserCreateModel>, UserCreateModelValidator>();
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.Cookie.Name = "SOFTWARE_ENGINEERING-Gutenberg";
        opt.Cookie.HttpOnly = true;
        opt.Cookie.SameSite = SameSiteMode.Strict;
        opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
        opt.ExpireTimeSpan = TimeSpan.FromDays(5);
        opt.LoginPath = new PathString("/Account/SignIn");
        opt.LogoutPath = new PathString("/Account/LogOut");
        opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
    });

var profiles = ProfileHelper.GetProfiles();
profiles.Add(new UserCreateModelProfile());

var configuration = new MapperConfiguration(opt =>
{
    opt.AddProfiles(profiles);
});
var mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
