using CleanArchitecture.Infraestructure.IoC;
using CleanArchitecture.MinimalApi;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins(configuration.GetValue<string>("APP_URL_REACT")!).AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    });
});
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Mi API",
        Version = "v1",
        Description = "Una API de ejemplo en .NET 9"
    });
    c.OperationFilter<SwaggerFileOperationFilter>();
});
DependencyContainer.RegisterServices(builder.Services, configuration);
var app = builder.Build();
app.MapOpenApi();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/openapi/v1.json", "Mi API V1");
    });
    app.UseReDoc(options =>
    {
        options.SpecUrl("/openapi/v1.json");
    });
}
app.UseCors(myAllowSpecificOrigins);
app.UseHttpsRedirection();
app.MapDocumentRoutes();
app.Run();
