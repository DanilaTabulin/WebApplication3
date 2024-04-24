using WebApplication3.Model;

namespace WebApplication3.Repository
{
    public interface IMovie
    {
        public Movie Add(Movie movie);
        public Movie Get(int id);
        public Movie Update(Movie movie);
        public List<Movie> GetAll();
        public Movie Dell(int id);
    }
}
