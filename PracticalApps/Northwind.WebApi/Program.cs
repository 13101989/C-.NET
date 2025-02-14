// IOutputFormatter, OutputFormatter
using Microsoft.AspNetCore.Mvc.Formatters;
using Packt.Shared; // AddNorthwindContext extension method
using Northwind.WebApi.Repositories; // ICustomerRepository, CustomerRepository
using Swashbuckle.AspNetCore.SwaggerUI; // SubmitMethod
using Microsoft.AspNetCore.HttpLogging; // HttpLoggingFields
using Microsoft.AspNetCore.Server.Kestrel.Core; // HttpProtocols

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddNorthwindContext();

builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
            WriteLine($"  {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes
        {
            WriteLine("  {0}, Media types: {1}",
              arg0: mediaFormatter.GetType().Name,
              arg1: string.Join(", ", mediaFormatter.SupportedMediaTypes));
        }
    }
})
.AddXmlDataContractSerializerFormatters()
.AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // default is 32k
    options.ResponseBodyLogLimit = 4096; // default is 32k
});

//builder.Services.AddW3CLogging(options =>
//{
//    options.AdditionalRequestHeaders.Add("x-forwarded-for");
//    options.AdditionalRequestHeaders.Add("x-client-ssl-protocol");
//});

builder.Services.AddHealthChecks()
  .AddDbContextCheck<NorthwindContext>();

builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.ListenAnyIP(5002, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
        listenOptions.UseHttps(); // HTTP/3 requires secure connections
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json","Northwind Service API Version 1");
        c.SupportedSubmitMethods(new[] {
      SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete });
    });
}

app.UseHttpLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHealthChecks(path: "/howdoyoufeel");

app.UseMiddleware<SecurityHeaders>();

app.MapControllers();

app.Run();
