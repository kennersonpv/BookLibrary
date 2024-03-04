using BookLibrary.Feature.Books;
using BookLibrary.Repository;
using BookLibrary.Repository.Repositories.Books;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

builder.Services.AddScoped<IBooksRepository, BooksRepository>();
builder.Services.AddScoped<IBookUseCase, BookUseCase>();

var connectionString = configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<BookLibraryDbContext>(options =>
options.UseSqlServer(connectionString, b => b.MigrationsAssembly("BookLibrary"))
);

var optionBuilder = new DbContextOptionsBuilder<BookLibraryDbContext>();
optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
