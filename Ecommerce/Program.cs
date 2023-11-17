 
using InfreaStructure.Implementation;
using InfreaStructure.ImplementationServices;
using InfreaStructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Services.Contractor;
using Services.ServicesContractor;
using System.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IServicesProduct, ServicesProducts>();

// inyeccion del Servicio Generico 

builder.Services.AddScoped(typeof(IServicesBase<>), typeof(ServicesBase<>));


builder.Services.AddDbContext<EcommerceDbContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("SaturdayEcommerce"))
      );
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
    pattern: "{controller=Address}/{action=index}/{id?}");

app.Run();
