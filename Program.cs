using Microsoft.EntityFrameworkCore;
using ServiceMate.Data;
using ServiceMate.Repositories;
using ServiceMate.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ServiceMateConnectionString");

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.WebHost.UseUrls();
builder.Services.AddDbContext<ServiceDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<IScheduledMaintenanceRepository, SqlScheduledMaintenanceRepository>();
builder.Services.AddScoped<IServiceRepository, SqlServiceRepository>();
builder.Services.AddScoped<IUserRepository, SqlUserRepository>();
builder.Services.AddScoped <IVehicleRepository, SqlVehicleRepository>();
builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
