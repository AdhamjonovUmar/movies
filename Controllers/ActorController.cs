using Microsoft.AspNetCore.Mvc;
using movies.Mappers;
using movies.Models;
using movies.Services;

namespace movies.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActorController : ControllerBase
{
    private readonly IActorService _as;

    public ActorController(IActorService actorService)
    {
        _as = actorService;
    }

    public async Task<IActionResult> PostAsync(NewActor actor)
    {
        var result = await _as.CreateAsync(actor.ToEntity());
        
        if(result.isSuccess)
        {
            return Ok();
        }
        return BadRequest(result.e.Message);
    }
}