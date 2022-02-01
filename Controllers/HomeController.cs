using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc.Models;
using MvcMovie.Data;

namespace dotnet_mvc.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly ILogger<MovieController> _logger;
    private readonly MvcMovieContext _context;

    public MovieController(ILogger<MovieController> logger, MvcMovieContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetTodoItem(int id)
    {
        var movie = await _context.Movie.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        return movie;
    }
}
