
using Serilog.Events;
using Serilog;
using System.Configuration;
using System.Reflection;

namespace WebMVCControllerAPIComboCascadeEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Logging.ClearProviders();   // NO Microsoft Logging - VEDERE Sezione Logging di appsettings.json

            // SERILOG
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build())
                .MinimumLevel.Override("Microsoft", LogEventLevel.Error)  // NO Microsoft Logging
                .Enrich.FromLogContext()
                .CreateLogger();

            var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, false);
            var config = configurationBuilder.Build();
                                            

            builder.Host.UseSerilog(logger);

            // SERILOG

            //  placing UseSerilogRequestLogging() after UseStaticFiles
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           /* builder.Services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(x => x.FullName);
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo { Title = "MyApi", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(xmlPath);
            });*/

            var app = builder.Build();


            /*app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API NAME 1.0.0.0"));*/

            // Configure the HTTP request pipeline.
           //if (app.Environment.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI();
            //}

            app.UseStaticFiles();

            //SERILOG
            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
