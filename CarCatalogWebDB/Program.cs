using CarCatalogWebDB.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Welcome");

app.MapGet("/all", async (ApplicationDbContext db) =>
{
    return await db.CarTable.ToListAsync();
});

app.Run();
