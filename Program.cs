using Customers.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Logging setup
builder.Logging.AddConsole();
builder.Logging.AddDebug();

// Add services to the container
builder.Services.AddControllersWithViews();

// Retrieve configuration settings
var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("DefaultConnection");

// Validate connection string
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Database connection string 'DefaultConnection' is missing.");
}

// Register ApplicationDbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Map default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();