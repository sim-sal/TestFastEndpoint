using FastEndpoints;
using TestFastEndpoint.Entities;
using TestFastEndpoint.Features.Endpoint;
using System.Threading;
using System.Threading.Tasks;
using TestFastEndpoint.Infrastucture.Data;

namespace TestFastEndpoint.Features.Endpoint
{
    public class Endpoint(ApplicationDbContext _dbContext) : Endpoint<Models.Request, Models.Response>
    {

        public override void Configure()
        {
            Post("/api/CreatePersonaggio");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Models.Request req, CancellationToken ct)
        {
            // Create a new Personaggio instance
            var newPersonaggio = Personaggio.Create(req.name, req.cartoon);

            // Add the new instance to the DbContext
            _dbContext.Personaggi.Add(newPersonaggio);

            // Save the changes to the database
            await _dbContext.SaveChangesAsync(ct);

            // Return a response
            await SendAsync(new Models.Response(newPersonaggio.Name, newPersonaggio.Cartoon));
        }
    }
}
