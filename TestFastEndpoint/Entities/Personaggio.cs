namespace TestFastEndpoint.Entities
{
    public class Personaggio
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Cartoon { get; set; }

        // Parameterless constructor for EF Core
        public Personaggio()
        {
        }

        private Personaggio( string name, string cartoon)
        {
            Name = name;
            Cartoon = cartoon;
        }

        public static Personaggio Create(string name, string cartoon)
        {
            return new Personaggio( name, cartoon);
        }
    }
}
