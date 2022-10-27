namespace WebLinqExercises.Data;

public class Movie
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int ReleaseYear { get; set; }

    public string Director { get; set; }

    public IEnumerable<Actor> Actors { get; set; }

    public override string ToString()
    {
        return string.Format("{0} ({1}) - {2}", Title, ReleaseYear, Director);
    }
}