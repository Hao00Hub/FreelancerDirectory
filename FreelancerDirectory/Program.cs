using Microsoft.EntityFrameworkCore;
using FreelancerDirectory.Data;

// Create Web Application
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>
    (opt => opt.UseInMemoryDatabase("UsersDb"));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Build the App
var app = builder.Build();

// Add this line to trigger seeding!
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApiContext>();
    dbContext.Database.EnsureCreated(); // This triggers OnModelCreating for InMemory DB
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseDefaultFiles(); // To serve index.html by default
app.UseStaticFiles();  // To allow access to static files like HTML/CSS/JS



app.MapControllers();

app.Run();
