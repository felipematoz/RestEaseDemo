using RestEase;
using Swapi.Models;
using System.Threading.Tasks;

namespace Swapi.Contracts
{
    public interface ISwapi
    {
        [Get("planets/{planetId}")]
        Task<Planet> GetPlanet([Path] long planetId);
    }
}
