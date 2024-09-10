using GAME_MAN.Data;
using GAME_MAN.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ScoreController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ScoreController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostScore([FromBody] Score score)
    {
        if (score == null)
        {
            return BadRequest();
        }

        _context.Scores.Add(score);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
