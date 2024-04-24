using System.ComponentModel.DataAnnotations;
using System.Numerics;
using WebApplication3.Model;

namespace WebApplication3.Repository
{
    public class MOCMovie : IMovie
    {
        private List<Movie> Movies;
        public MOCMovie()
        {
            Movies ??= new List<Movie>();
            Movies.Add(new() { Id = 1, Title = "Звёздные войны", Website = "first@first.ru" });
            Movies.Add(new() { Id = 2, Title = "Индиана Джонс", Website = "first@first.ru" });
            Movies.Add(new() { Id = 3, Title = "Железный человек", Website = "first@first.ru" });
        }
        public Movie? Get(int id)
        {
            return Movies.Where(x => x.Id == id).ToList().FirstOrDefault();
        }
        public List<Movie> GetAll()
        {
            return Movies;
        }
        public Movie Update(Movie movie)
        {
            var movieDB = Get(movie.Id);
            if (movieDB != null)
            {
                Movies.Remove(movie);
            }
            Movies.Add(movie);
            return movie;
        }

        Movie IMovie.Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        Movie IMovie.Dell(int id)
        {
            throw new NotImplementedException();
        }
    }
}
