using Microsoft.IdentityModel.Tokens;
using WebApplication3.Model;

namespace WebApplication3.Repository
{
    public class SQLMovie : IMovie
    {
        private readonly AppDbContext _appDbContext;

        public SQLMovie(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Movie? Get(int Id)
        {
            return _appDbContext.Movies.Where(u => u.Id == Id).ToList().FirstOrDefault();
        }

        public List<Movie> GetAll()
        {
            return _appDbContext.Movies.ToList();
        }

        Movie IMovie.Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        Movie IMovie.Dell(int id)
        {
            var movie = Get(id);
            _appDbContext.Remove(movie);
            _appDbContext.SaveChanges();
            return movie;
        }

        Movie IMovie.Update(Movie movie)
        {
            if (movie.Id == 0)
            {
                _appDbContext.Movies.Add(movie);
            }
            else
            {
                _appDbContext.Movies.Update(movie);
            }
            _appDbContext.SaveChanges();
            return movie;
        }
    }
}
