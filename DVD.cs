public class Media : DVD 
{
    string duree;
    string realisator;

    public virtual void AfficherInfos()
    {
        Console.Out.Write("Durée : " + duree + ", Réalisateur : " + realisator);
    }
}