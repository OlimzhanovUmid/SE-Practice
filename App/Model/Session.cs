using System.ComponentModel.DataAnnotations;
namespace App.Model;

public class Session
{
    public int SessionId { get; set; }
    public string? MovieName { get; set; }
    public string? Date { get; set; }
    public string? Time { get; set; }
    public int? SessionDuration { get; set; }
    
    [Required]
    public CinemaHall? CinemaHall { get; set; }
    public int CinemaHallId { get; set; }
}