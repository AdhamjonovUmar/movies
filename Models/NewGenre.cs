using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace movies.Models;

public class NewGenre
{   
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
}