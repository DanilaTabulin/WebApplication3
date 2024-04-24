using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;
using WebApplication3.Repository;

namespace WebApplication3.Pages
{
    public class MoviesModel : PageModel
    {
        public MoviesModel(IMovie moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        private IMovie _moviesRepository;
        public List<Movie> Movies { get; set; }
        public IActionResult OnGet()
        {
            Movies = _moviesRepository.GetAll();
            return Page();
        }
    }  
}
