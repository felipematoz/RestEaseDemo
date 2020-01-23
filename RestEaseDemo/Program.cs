using RestEase;
using Swapi.Contracts;
using Swapi.Models;
using System;
using System.Threading.Tasks;

namespace RestEaseDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ISwapi apiClient = RestClient.For<ISwapi>("https://swapi.co/api/");

            Planet planet = await apiClient.GetPlanet(1);
            Console.WriteLine($"Planet: {planet.Name}, Population: {planet.Population}");
        }
    }
}
