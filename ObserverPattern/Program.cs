

//Weather Station
//News Agency

using ObserverPattern.Apps;

WeatherStation weatherStation = new();

NewsAgency newsAgency1 = new("Alpha News Agency");

weatherStation.Attach(newsAgency1);


NewsAgency newsAgency2 = new("Omega News Agency");

weatherStation.Attach(newsAgency2);


weatherStation.Temperature = 31.2f;
weatherStation.Temperature = 28f;
weatherStation.Temperature = 46.8f;
weatherStation.Temperature = 15.3f;



Console.ReadLine();