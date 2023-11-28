var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policies =>
{
    policies.AddDefaultPolicy(bydefault =>
    {
        bydefault.AllowAnyHeader();
        bydefault.AllowAnyMethod();
        bydefault.AllowAnyOrigin();
    });


    //We will have to add [CORS("customerPolicy")] Above controller name in controller class so that, only customers from Amazon.com can make only GET and POST calls
    policies.AddPolicy("customerPolicy", policy =>
    {
        policy.AllowAnyHeader().WithOrigins("https://wwww.amazon.com").WithMethods(new string[] { "GET", "POST" });
    });
});

builder.Services.AddScoped(typeof(shoppingAPI_CORS.Models.EF.ShoppingDbContext));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
