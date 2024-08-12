namespace Movies.Core.Entities;

public class Movie: Entity
{
    public string MovieName { get; set; }
    public string DirectorName { get; set;}
    public string ReleasedYear { get; set;}
}
