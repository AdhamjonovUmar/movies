using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movies.Models;

public class NewMovie
{
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }
    
    [Required]
    [MaxLength(1024)]
    public string Description { get; set; }
    
    [Required]
    [Range(0, 10)]
    public double Rating { get; set; }
    
    [Required]
    public DateTimeOffset ReleaseDate { get; set; }

    [Required]
    public IEnumerable<Guid> GenreIds { get; set; }

    [Required]
    public IEnumerable<Guid> ActorIds { get; set; }
}