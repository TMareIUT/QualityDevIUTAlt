public class Media : CD 
{
    string artist;
    string style;

    public virtual void AfficherInfos()
    {
        Console.Out.Write("Artiste : " + artist + ", Style : " + style);
    }
}