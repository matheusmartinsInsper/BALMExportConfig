using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Builders.Interfaces;
using ExportConfigurationBALM.Directors;
using ExportConfigurationBALM.Directors.Interfaces;

namespace ExportConfigurationBALM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddScoped<IBuilderdDocumentType, BuilderDocumentType>();
            builder.Services.AddScoped<IDirectorDocumentType, DirectorDocumentType>();

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
        }
    }
}