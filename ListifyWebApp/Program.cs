using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static ListifyWebApp.DataAccess.IRepository;

namespace ListifyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IRepository<Listify>>(provider =>
            {
                string endpointUri = "https://localhost:8081";
                string primaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
                var client = new CosmosClient(endpointUri, primaryKey);

                var databaseName = "listifyDB";
                var containerName = "listifyContainer";

                var database = client.CreateDatabaseIfNotExistsAsync(databaseName).GetAwaiter().GetResult();

                var container = database.Database.CreateContainerIfNotExistsAsync(containerName, "/partitionKey").GetAwaiter().GetResult();

                return new CosmosDBRepository<Listify>(container.Container);
            });

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<PretendDatabase>();
            builder.Services.AddTransient<InitDB>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}