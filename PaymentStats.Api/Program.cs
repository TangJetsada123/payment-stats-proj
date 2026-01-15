using Microsoft.EntityFrameworkCore;
using PaymentStats.Api.Data;
using PaymentStats.Api.Data.Interfaces;
using PaymentStats.Api.Services;
using PaymentStats.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173") // React
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddScoped<IPaymentStatsRepository, PaymentStatsRepository>();
builder.Services.AddScoped<IPaymentStatsService, PaymentStatsService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "Payment Stats 2C2P API",
        Version = "v1",
        Description = "This is the simple API for cal payment stats made by Tang Jetsada :)"
    });
});
// builder.Services.AddHttpsRedirection(options =>
// {
//     options.HttpsPort = 5170;
// });

var app = builder.Build();

app.UseCors("AllowFrontend");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.MapControllers();

app.Run();
