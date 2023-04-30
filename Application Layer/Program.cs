using BusinessAccessLayer.IService;
using BusinessAccessLayer.Services;
using DataAccessLayer.Data;
using DataAccessLayer.IRepo;
using DataAccessLayer.Repo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepos,Repos>();
builder.Services.AddScoped<IServices,Services>();
builder.Services.AddDbContext<ApplicationDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
