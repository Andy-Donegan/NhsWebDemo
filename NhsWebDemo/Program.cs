using Microsoft.EntityFrameworkCore;
using NhsWebDemo.DataContext;
using NhsWebDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LocalDBContext>(options => options.UseInMemoryDatabase(databaseName: "LocalUsers"));
builder.Services.AddDbContext<NhsDBContext>(options => options.UseInMemoryDatabase(databaseName: "NhsWebDemoDB"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    // Get the instance of LocalDBContext in our services layer
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<LocalDBContext>();

    // Call the DataGenerator to create sample data
    LocalUserDataGenerator.Initialize(services);

    // Get the instance of LocalDBContext in our services layer
    var servicesNhs = scope.ServiceProvider;
    var contextNhs = servicesNhs.GetRequiredService<NhsDBContext>();

    // Call the DataGenerator to create sample data
    NationalModelDataGenerator.Initialize(services);
}


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
