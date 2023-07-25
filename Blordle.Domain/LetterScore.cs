namespace Blordle.Domain;

public class LetterScore
{
    public int Id { get; set; } 
    public char Letter { get; set; }
    public Score Eval { get; set; }
}
