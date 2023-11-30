using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shoppingMVC_oAuth.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();



builder.Services.AddAuthentication().AddFacebook(option =>
{
    //we have to create an app on developer.facebook.com, and we will get appid and app secret from there
    option.AppId = "1940346559694923";
    option.AppSecret = "d04266cb86af1d4c830c6231c1e5b8e3";
});

builder.Services.AddAuthentication().AddGoogle(option =>
{
    //we will have to create new app on Google and get clientid and client secret
    option.ClientId = "328479835743976573659";
    option.ClientSecret = "dkljfjioh9jlfkjaioghuhgg8549867896789";
});




builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
