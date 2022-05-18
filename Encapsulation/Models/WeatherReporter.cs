// See https://aka.ms/new-console-template for more information
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string _location;
        private double _temperature;
        private const int _fahrenheit = 32;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string DisplayWeatherReport()
        {
            double newTemp = (9.0 / 5.0) * _temperature + _fahrenheit;
            return $"I am in {_location} and it is {GetWeatherConditionAtLocation()}. {GetHowTempFeelsLike()}. The temperature in Fahrenheit is {newTemp}.";
        }


        public string GetWeatherConditionAtLocation()
        {
            switch(_location)
            {
                case "London":
                    return "🌦";

                case "California":
                    return "🌅";

                case "Cape Town":
                    return "🌤";

                default:
                    return "🔆";

            }
            
        }

        public string GetHowTempFeelsLike()
        {

            switch (_temperature)
            {
                case >30:
                    return "It's too hot 🥵!";

                case <10:
                    return "It's too cold 🥶!";

                default:
                    return "Ahhh...it's just right 😊!";

            }
           

        }
    }
}

