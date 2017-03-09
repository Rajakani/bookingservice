using MovieCoreApp.Models;
using System.Collections.Generic;

namespace MovieCoreApp.Repository.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        int GetAvailablity(long key);
    }
}
