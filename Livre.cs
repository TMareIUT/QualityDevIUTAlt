public class Media : Livre 
{
    string author;
    string editor;

    public virtual void AfficherInfos()
    {
        Console.Out.Write("Auteur : " + author + ", Editeur : " + editor);
    }
}