using Microsoft.EntityFrameworkCore;
using movies.Data;
using movies.Entities;

namespace movies.Services;

public class ActorService : IActorService
{
    private readonly MoviesContext _ctx;

    public ActorService(MoviesContext context)
    {
        _ctx = context;
    }

    public async Task<(bool isSuccess, Exception e, Actor actor)> CreateAsync(Actor actor)
    {
        try
        {
            await _ctx.Actors.AddAsync(actor);
            await _ctx.SaveChangesAsync();
            return(true, null, actor);
        }
        catch(Exception e)
        {
            return(false, e, null);
        }
    }

    public async Task<(bool isSuccess, Exception e)> DeleteAsync(Guid id)
    {
        try
        {
            var actor = await GetAsync(id);

            if(actor == default(Actor))
            {
                return (false, new Exception("Not found"));
            }

            _ctx.Actors.Remove(actor);
            await _ctx.SaveChangesAsync();
            return(true, null);

        }
        catch (Exception e)
        {
            return(false, e);
        }
    }

    public Task<bool> ExistAsync(Guid id)
        => _ctx.Actors.AnyAsync(a => a.Id == id);

    public async Task<List<Actor>> GetAllAsync()
        => await _ctx.Actors.ToListAsync();

    public Task<List<Actor>> GetAllAsync(string fullname)
        => _ctx.Actors
            .AsNoTracking()
            .Where(a => a.Fullname == fullname)
            .ToListAsync();

    public Task<Actor> GetAsync(Guid id)
        => _ctx.Actors.FirstOrDefaultAsync(a => a.Id == id);
}