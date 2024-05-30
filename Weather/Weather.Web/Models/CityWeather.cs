namespace Weather.Web.Models
{
    public class CityWeather
    {
        public string CityUniqueCode { get; set; }
        public string CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }

        public List<CityWeather> CityLists = new List<CityWeather>() {

            new CityWeather()
            {
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime = new DateTime(2030, 01, 01, 8, 0, 0),
                TemperatureFahrenheit = 33
            },
            new CityWeather()
            {
                CityUniqueCode = "NYC",
                CityName = "London",
                DateAndTime = new DateTime(2030, 01, 01, 3, 0, 0),
                TemperatureFahrenheit = 60
            },
            new CityWeather()
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = new DateTime(2030, 01, 01, 9, 0, 0),
                TemperatureFahrenheit = 82

            }
        };
    }   
}
