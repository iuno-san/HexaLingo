using HexaLingo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MySql.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HexaLingoDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("HexaLingoConnection")!);
});

/*builder.Services.AddDbContext<HexaLingoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HexaLingoConnection")));
*/

/*using (var context = new HexaLingoDbContext(new DbContextOptionsBuilder<HexaLingoDbContext>().UseMySQL(builder.Configuration.GetConnectionString("HexaLingoConnection")!).Options))
{
    try
    {
        context.Database.Migrate();
        context.Database.CanConnect();
        Console.WriteLine(context.Database.CanConnect());

        var data = context.Words.ToList();
        Console.WriteLine(data);
        foreach (var item in data)
        {
            Console.WriteLine(item.Category);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error establishing connection to the database: {ex.Message}");
    }
    finally
    {
        context.Database.CloseConnection();
    }
}*/

builder.Services.AddControllersWithViews();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "dark-mode",
        pattern: "dark-mode/{isDarkMode}",
        defaults: new { controller = "DarkMode", action = "SetDarkModePreference" });
});

app.Run();
