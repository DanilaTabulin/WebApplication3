using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;
using WebApplication3.Repository;

namespace WebApplication3.Pages
{
    public class MovieModel : PageModel
    {
        public MovieModel(IMovie moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        private IMovie _moviesRepository;
        public Movie Movie { get; set; }
        public IActionResult OnGet(int Id)
        {
            Movie = _moviesRepository.Get(Id);
            return Page();
        }
        public IActionResult OnPost(Movie? movieForm)
        {
            var userDB = _moviesRepository.Update(movieForm);
            if (userDB == null) return NotFound();
            return RedirectToPage("Movies");
        }
    }
}
