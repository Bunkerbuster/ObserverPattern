using ObserverPattern.Interface;

namespace ObserverPattern.Apps
{
    public class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }

        public NewsAgency(string name)
        {
            AgencyName = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine(String.Format($"{AgencyName} reporting temparature {weatherStation.Temperature} degree celcius "));
                Console.WriteLine();
            }

        }

    }
}
