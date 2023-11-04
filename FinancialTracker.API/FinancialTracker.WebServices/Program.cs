using FinancialTracker.WebServices.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services
    .AddDatabase(configuration)
    .AddIdentity()
    .AddJwtAuthentication(configuration)
    .AddAuthorization()
    .AddApplicationServices()
    .AddSwagger()
    .AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app
    .UseRouting()
    .UseCors(options => options
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod())
    .UseAuthentication()
    .UseAuthorization()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

app.Run();