using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string Genre { get; set; }
    public string Search { get; set; }
}
