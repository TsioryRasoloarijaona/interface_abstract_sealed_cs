namespace interface_abstract_sealed;

public class EtudiantMaster : Etudiant
{
    private string memoireSujet { get; set; }

    public EtudiantMaster(string nom, int age, string memoireSujet) : base(nom, age, "master")
    {
        this.memoireSujet = memoireSujet;
    }

    public override void etudier()
    {
        Console.WriteLine(nom + " etudie sur sa memoire sur le sujet " + memoireSujet);
    }

    public override void passerExamen()
    {
        Console.WriteLine(nom + " passe un examen de master");
    }

    public override void afficherDetails()
    {
        Console.WriteLine("nom : " +nom +"\n"+"age : "+ age +"\n"+"memoire : " + memoireSujet);
    }
}