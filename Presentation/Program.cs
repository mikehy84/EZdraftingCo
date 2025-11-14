using Application.Mapper;
using Application.DTO.ProjectDTO;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Azure.Storage.Blobs;
using Application.Services;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;
using Domain.Entities;
using Application.DTO.UserAccountDTO;
using Infrastructure.Data;
using Application.Services.Azure;
using Application.Interfaces;
using Infrastructure.Repository;
using Application.Services.ProjectDir;
using Application.Services.UserAccountDir;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var conStr = builder.Configuration.GetConnectionString("EZDrafting");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(conStr, sqlOptions =>
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(5),
            errorNumbersToAdd: null
        )
    ));

builder.Services.AddIdentity<UserAccount, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


//builder.Services.AddDefaultIdentity<IdentityUser>(options =>
//    options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();








// injecting blob service here
builder.Services.Configure<AzureStorageSettings>(
    builder.Configuration.GetSection("AzureStorage"));

// Register BlobServiceClient using the config
builder.Services.AddSingleton<BlobServiceClient>(sp =>
{
    var options = sp.GetRequiredService<IOptions<AzureStorageSettings>>().Value;
    return new BlobServiceClient(options.ConnectionString);
});

// Register your blob service
builder.Services.AddScoped<IBlobService, BlobService>();



builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IProjectService<ProjectDto>, ProjectService>();
builder.Services.AddScoped<IUserAccountService<UserAccountDto>, UserAccountService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}






app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    context.Response.Headers.CacheControl = "no-store, no-cache, must-revalidate, max-age=0";
    context.Response.Headers["Pragma"] = "no-cache";
    context.Response.Headers["Expires"] = "0";
    await next();
});


app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{area=Client}/{controller=Home}/{action=Index}/{id?}");


// Replace the app.UseEndpoints block with top-level route registrations as follows:

// Area-based route (Admin, Identity, etc.)
//app.MapControllerRoute(
//   name: "areaRoute",
//   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//// Default route for non-areas
//app.MapControllerRoute(
//   name: "defaultRoute",
//   pattern: "{controller=Home}/{action=Index}/{id?}");





app.Run();
