using OnlineShop.Catalog.Abstractions.Interfaces.Database;
using OnlineShop.Catalog.DataAccess;
using OnlineShop.Catalog.Infrastructure.DependencyInjection;
using OnlineShop.Catalog.Infrastructure.Startup;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

var builder = WebApplication.CreateBuilder(args);

var databaseConnectionString = builder.Configuration.GetConnectionString("Default")
            ?? throw new ArgumentNullException("ConnectionStrings:AppDatabase", "Database connection string is not initialized");

builder.Services.AddDbContext<AppDbContext>(
    new DbContextOptionsSetup(databaseConnectionString).Setup);
builder.Services.AddAsyncInitializer<DatabaseInitializer>();

// Add services to the container.

builder.Services.AddScoped<IAppDbContext>(s => s.GetRequiredService<AppDbContext>());

MediatRModule.Register(builder.Services);
builder.Services.AddAutoMapper(typeof(CreateProductCommand).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
