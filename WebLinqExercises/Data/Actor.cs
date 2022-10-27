namespace WebLinqExercises.Data;

public class Actor
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Birthyear { get; set; }

    public override string ToString()
    {
        return Name;
    }
}