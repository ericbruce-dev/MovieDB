using MovieDB.Models.Database;
using MovieDB.Models.TMDB;
using System.Threading.Tasks;

namespace MovieDB.Services.Interfaces
{
    public interface IDataMappingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);
    }
}
