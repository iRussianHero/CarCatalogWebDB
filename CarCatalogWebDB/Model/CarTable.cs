namespace CarCatalogWebDB.Model
{
    public class CarTable
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public int EngineVolume { get; set; }
        public int ManufacturingYear { get; set; }

        public CarTable()
        {
            Id = default;
            CarName = "";
            BrandName = "";
            EngineVolume = 0;
            ManufacturingYear = 1990;
        }
    }
}
