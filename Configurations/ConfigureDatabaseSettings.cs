namespace MedicAppAPI.Configurations
{
    public class ConfigureDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string MedicationsCollectionName { get; set; } = null!;
    }
}