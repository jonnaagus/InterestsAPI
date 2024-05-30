using InterestsAPI.Data;
using InterestsAPI.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace InterestsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Get all persons
            app.MapGet("/persons", async (ApplicationDbContext context) =>
            {
                var persons = await context.Persons.Include(p => p.InterestParticipations).ToListAsync();
                if (persons == null)
                {
                    return Results.NotFound("Hittade inga personer");
                }

                return Results.Ok(persons);
            });

            // Create person
            app.MapPost("/persons", async (Person person, ApplicationDbContext context) =>
            {
                context.Persons.Add(person);
                await context.SaveChangesAsync();
                return Results.Created($"/persons/{person.PersonId}", person);
            });

            // Get person by id
            app.MapGet("/persons/{id:int}", async (int id, ApplicationDbContext context) =>
            {
                var person = await context.Persons
                    .Include(p => p.InterestParticipations)
                    .ThenInclude(ip => ip.Interest)
                    .FirstOrDefaultAsync(p => p.PersonId == id);

                if (person == null)
                {
                    return Results.NotFound("Ingen person hittades");
                }

                return Results.Ok(person);
            });

            // Get all interests
            app.MapGet("/interests", async (ApplicationDbContext context) =>
            {
                var interests = await context.Interests.ToListAsync();
                if (interests == null)
                {
                    return Results.NotFound("Hittade inga intressen");
                }

                return Results.Ok(interests);
            });

            // Create interest
            app.MapPost("/interests", async (Interest interest, ApplicationDbContext context) =>
            {
                context.Interests.Add(interest);
                await context.SaveChangesAsync();
                return Results.Created($"/interests/{interest.InterestId}", interest);
            });

            // Create interest participation
            app.MapPost("/interestparticipations", async (InterestParticipation interestParticipation, ApplicationDbContext context) =>
            {
                context.InterestParticipations.Add(interestParticipation);
                await context.SaveChangesAsync();
                return Results.Created($"/interestparticipations/{interestParticipation.Id}", interestParticipation);
            });

            // Adding links for an interest participation
            app.MapPost("/interestparticipations/{id:int}/links", async (int id, string updatedLink, ApplicationDbContext context) =>
            {
                var interestParticipation = await context.InterestParticipations.FindAsync(id);
                if (interestParticipation == null)
                {
                    return Results.NotFound("Hittade ingen intresseparticipation");
                }

                if (interestParticipation.Resources == null)
                {
                    interestParticipation.Resources = new List<string>();
                }

                interestParticipation.Resources.Add(updatedLink);

                await context.SaveChangesAsync();
                return Results.Created($"/interestparticipations/{id}/links", updatedLink);
            });

            app.Run();
        }
    }
}
