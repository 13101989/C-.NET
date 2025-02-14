using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Northwind.Mvc.Data;
using Packt.Shared; // AddNorthwindContext extension method
using System.Net.Http.Headers; // MediaTypeWithQualityHeaderValue
using System.Net; // HttpVersion

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // enable role management
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddNorthwindContext();
builder.Services.AddOutputCache(options =>
{
    options.DefaultExpirationTimeSpan = TimeSpan.FromSeconds(1);
    options.AddPolicy("views", p => p.SetVaryByQuery("alertstyle"));
});

builder.Services.AddHttpClient(name: "Northwind.WebApi",
  configureClient: options =>
  {
      options.DefaultRequestVersion = HttpVersion.Version30;
      options.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrLower;

      options.BaseAddress = new Uri("https://localhost:5002/");
      options.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue(
        mediaType: "application/json", quality: 1.0));
  });

builder.Services.AddHttpClient(name: "Minimal.WebApi",
  configureClient: options =>
  {
      options.BaseAddress = new Uri("https://localhost:5003/");
      options.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue(
        "application/json", 1.0));
  });

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

app.UseOutputCache();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .CacheOutput("views");

app.MapRazorPages();

app.MapGet("/notcached", () => DateTime.Now.ToString());
app.MapGet("/cached", () => DateTime.Now.ToString()).CacheOutput();

app.Run();
