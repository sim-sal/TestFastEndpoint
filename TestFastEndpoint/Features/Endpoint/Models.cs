namespace TestFastEndpoint.Features.Endpoint
{
    public class Models
    {
        public record Request(string name, string cartoon);
        public record Response(string name, string cartoon);

    }
}
