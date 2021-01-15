using System;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            var trafficLight = new TrafficLight();
            Console.WriteLine(trafficLight.IsRedOn);
            Console.WriteLine(trafficLight.IsYellowOn);
            Console.WriteLine(trafficLight.IsGreenOn);
            trafficLight.Next();
            Console.WriteLine(trafficLight.IsRedOn);
            Console.WriteLine(trafficLight.IsYellowOn);
            Console.WriteLine(trafficLight.IsGreenOn);
        }
    }
}
