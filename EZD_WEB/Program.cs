using EZD_BLL.Mapper;
using EZD_BLL.ProjectDir;
using EZD_DAL.Data;
using EZD_DAL.Repository.IRepository;
using EZD_DAL.Repository;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var conStr = builder.Configuration.GetConnectionString("EZdrafting");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(conStr));

builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IService<ProjectDto>, ProjectService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
