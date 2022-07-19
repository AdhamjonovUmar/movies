using movies.Entities;

namespace movies.Services;

public class GenreService : IGenreService
{
    public Task<(bool IsSuccess, Exception Exception, Genre Genre)> CreateAsync(Genre genre)
    {
        throw new NotImplementedException();
    }

    public Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<List<Genre>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Genre> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}