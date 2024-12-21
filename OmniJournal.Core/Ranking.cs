namespace OmniJournal.Core;

public class Ranking
{
    public int Rank { get; set; }
    public string? Name { get; set; }   //If name is null use rank?
    public byte[]? Icon { get; set; }
}
