using MovieCoreApp.Models;
using System.Collections.Generic;

namespace MovieCoreApp.Repository.Interfaces
{
    public interface ICinemaRepository
    {
       // void Add(Cinema cinema);
        IEnumerable<Cinema> GetCinemas();
        ICollection<Movie> GetMovies(long key);
        Cinema Find(long key);
    }
}
