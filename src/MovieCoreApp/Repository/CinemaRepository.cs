using MovieCoreApp.Models;
using MovieCoreApp.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MovieCoreApp.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaContext _context;

        public CinemaRepository(CinemaContext context)
        {
            _context = context;
            AddCinemas();          
        }

        public IEnumerable<Cinema> GetCinemas()
        {
            return _context.Cinemas.ToList();
        }

        public ICollection<Movie> GetMovies(long key)
        {
            Cinema cinema = Find(key);
            return cinema.Movies.ToList();
        }

        public Cinema Find(long key)
        {
            return _context.Cinemas.FirstOrDefault(t => t.Key == key);
        }

        private void AddCinemas()
        {

            Movie movie1 = new Movie { Name = "Minnale", Availability = 20 };
            Movie movie2 = new Movie { Name = "The Prestige", Availability = 10 };
            Movie movie3 = new Movie { Name = "The Dark Knight", Availability = 80 };

            Cinema cinema1 = new Cinema { Name = "PVR Chennai" };
            cinema1.Movies.Add(movie1);
            cinema1.Movies.Add(movie2);
            cinema1.Movies.Add(movie3);

            Movie movie4 = new Movie { Name = "Barfi", Availability = 60 };
            Movie movie5 = new Movie { Name = "Queen", Availability = 2 };
            Movie movie6 = new Movie { Name = "InterStellar", Availability = 340 };

            Cinema cinema2 = new Cinema { Name = "PVR Mumbai" };
            cinema2.Movies.Add(movie4);
            cinema2.Movies.Add(movie5);
            cinema2.Movies.Add(movie6);


            Movie movie7 = new Movie { Name = "Pink", Availability = 30 };
            Movie movie8 = new Movie { Name = "Neerja", Availability = 23 };
            Movie movie9 = new Movie { Name = "Interstellar", Availability = 67 };

            Cinema cinema3 = new Cinema { Name = "PVR Delhi" };
            cinema3.Movies.Add(movie7);
            cinema3.Movies.Add(movie8);
            cinema3.Movies.Add(movie9);


            _context.Cinemas.Add(cinema1);
            _context.Cinemas.Add(cinema2);
            _context.Cinemas.Add(cinema3);

            _context.SaveChanges();

        }

    }
}
