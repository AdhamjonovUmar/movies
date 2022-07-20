using movies.Entities;

namespace movies.Services;

public interface IActorService
{
    Task<(bool isSuccess, Exception e, Actor actor)> CreateAsync(Actor actor);
    Task<List<Actor>> GetAllAsync();
    Task<Actor> GetAsync(Guid id);
    Task<List<Actor>> GetAllAsync(string fullname);
    Task<(bool isSuccess, Exception e)> DeleteAsync(Guid id);
    Task<bool> ExistAsync(Guid id);
}