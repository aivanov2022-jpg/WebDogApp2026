using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebDogApp.Infrastructure.Data.Domain;

using WebDogApp2026.Infastructure.Data;

namespace WebDogApp.Infrastructure.Data.infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        { 
            using var serviceScope = app.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            var data = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedBreads(data);

            return app;

        }


        private static void SeedBreads(ApplicationDbContext data) 
        {
         if (data.Breeds.Any())
         {
                return;
         }
            data.Breeds.AddRange(new[]
            {
                new Breed {Name="Husky"},
                new Breed {Name="Pincher"},
                new Breed {Name="Cocer spaniol"},
                new Breed {Name="Dachshund"},
                new Breed {Name="Doberman"},
            });
            data.SaveChanges();
        
        
        }
    }
}
