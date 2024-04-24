using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите название фильма")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Введите сайт для поиска")]
        public string Website { get; set; }
        public string Author { get; set; }
        public string Fax { get; set; }
        public Movie()
        {
            Title ??= string.Empty;
            Website ??= string.Empty;
            Author ??= string.Empty;
            Fax ??= string.Empty;
        }
    }
}
