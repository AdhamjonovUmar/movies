using movies.Entities;

namespace movies.Services;

public class ActorService : IActorService
{
    public Task<(bool isSuccess, Exception e, Actor actor)> CreateAsync(Actor actor)
    {
        throw new NotImplementedException();
    }

    public Task<(bool isSuccess, Exception e, Actor actor)> DeleteAsync(Actor actor)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Actor>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Actor>> GetAllAsync(string fullname)
    {
        throw new NotImplementedException();
    }

    public Task<Actor> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}