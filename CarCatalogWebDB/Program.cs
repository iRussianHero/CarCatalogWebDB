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

app.MapPost("/add", async (CarTable data, ApplicationDbContext db) =>
{
    db.CarTable.Add(data);
    await db.SaveChangesAsync();
    return data;
});

app.MapPost("/delete", async (CarTable data, ApplicationDbContext db) =>
{
    db.CarTable.Remove(data);
    await db.SaveChangesAsync();
    return data;
});

app.MapPost("/update", async (CarTable data, ApplicationDbContext db) =>
{
    db.CarTable.Update(data);
    await db.SaveChangesAsync();
    return data;
});

app.MapPost("/choose", async (CarTable data, ApplicationDbContext db) =>
{
    List<CarTable> allCars = new List<CarTable>();
    allCars = await db.CarTable.ToListAsync();
    foreach (CarTable car in allCars)
    {
        if (car.Id == data.Id) return car;
    }
    return null;
});

app.Run();
