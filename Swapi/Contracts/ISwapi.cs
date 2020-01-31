using RestEase;
using Swapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swapi.Contracts
{
    public interface ISwapi
    {
        [Get("planets/{planetId}")]
        Task<Planet> GetPlanetAsync([Path] long planetId);

        [Get("species/{specieId}")]
        Task<Specie> GetSpecieAsync([Path] long specieId);

        [Get("vehicles/{vehicleId}")]
        Task<Vehicle> GetVehicleAsync([Path] long vehicleId);

        [Get("vehicles/")]
        Task<Vehicle> FetchAllVehiclesAsync();

        [Get("starships/{starshipId}")]
        Task<Starship> GetStarshipAsync([Path] long starshipId);

        [Get("starships/")]
        Task<IEnumerable<Starship>> FetchAllStarshipsAsync();

        [Get("films/{filmId}")]
        Task<Film> GetFilmAsync([Path] long filmId);
        
        [Get("films/")]
        Task<IEnumerable<Film>> FetchAllFilmsAsync(); 

        [Get("people/{peopleId}")]
        Task<People> GetPeopleAsync([Path] long peopleId);

        [Get("people/")]
        Task<IEnumerable<People>> FetchAllPeopleAsync();
    }
}
