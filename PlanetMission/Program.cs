using System;

namespace PlanetMission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Venus().MissionInfo());
            Console.WriteLine(new Mars().MissionInfo());
        }
    }
}
