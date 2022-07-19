using movies.Entities;

namespace movies.Services;

public class MovieService : IMovieService
{
    public Task<(bool IsSuccess, Exception Exception, Movie Movie)> CreateAsync(Movie movie)
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

    public Task<List<Movie>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Movie>> GetAllAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}