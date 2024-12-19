using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class UpdateGameDTo(
    [Required][StringLength(50)]string Name,
    int GenreId,
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);