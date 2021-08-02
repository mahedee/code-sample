namespace Catalog.API
{
    public class CatalogSettings
    {
        public string ConnectionString { get; set; }
        public string ServiceName { get; set; }
        public string PicBaseUrl { get; set; }
        public string PATH_BASE { get; set; }

        public DatabaseSettings DatabaseSettings { get; set; }
    }
}
