namespace MapsExample
{
    public class Model
    {
        public double Value { get; set; }
        public string Country { get; set; }
        public double Population { get; set; }
        public double Density { get; set; }
        public Model(double value, string country, double population, double density)
        {
            Value = value;
            Country = country;
            Population = population;
            Density = density;
        }
    }
}