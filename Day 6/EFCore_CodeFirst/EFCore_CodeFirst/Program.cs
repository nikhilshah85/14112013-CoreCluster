using EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


IConfiguration configuration = builder.Build().Configuration;
var connectionString = configuration.GetConnectionString("myserver");



//builder.Services.AddSqlServer<EmployeeManagementDBContext>(connectionString);

builder.Services.AddDbContext<EmployeeManagementDBContext>(opts => opts.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["myserver"].ConnectionString));

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
