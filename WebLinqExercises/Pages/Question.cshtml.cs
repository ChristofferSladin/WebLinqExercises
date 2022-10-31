using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Data;

namespace WebLinqExercises.Pages
{
    public class QuestionModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public QuestionModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string id)
        {
            if (id == "1")
            {
                ViewData["data"] = Data.Repository
                    .GetAllMovies()
                    .Where(movie => movie.ReleaseYear > 1990 && movie.ReleaseYear < 2000)
                    .ToList()
                    .ToHtmlTable();
            }
            else if (id == "2")
            {
                ViewData["data"] = Data.Repository
                    .GetAllMovies()
                    .Where(movie => movie.Actors.Count() == 3)
                    .ToList()
                    .ToHtmlTable();
            }
            else if (id == "3")
            {
                ViewData["data"] = Data.Repository
                    .GetAllMovies()
                    .ToHtmlTable();
            }
            else if (id == "4")
            {
                ViewData["data"] = Data.Repository.GetAllActors().ToHtmlTable();
            }
            else if (id == "5")
            {
                ViewData["data"] = Data.Repository.GetAllActors()
                    .Where(movie => movie.Name.Contains("g") || movie.Name.Contains("G"))
                    .ToList()
                    .ToHtmlTable();
            }
            else if (id == "6")
            {
                ViewData["data"] = Data.Repository
                    .GetAllActors()
                    .Where(actor => actor.Birthyear < 2000)
                    .ToList()
                    .ToHtmlTable();
            }
            else if (id == "7")
            {
                ViewData["data"] = Data.Repository
                    .GetAllMovies()
                    .Where(x => x.Actors.Count() > 0)
                    .Where(i => i.Title.Length > 0)
                    .Where(j => j.Director.Length > 0)
                    .ToList()
                    .ToHtmlTable();
            }
            else if (id == "8")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "9")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "10")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "11")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }

        }
    }
}