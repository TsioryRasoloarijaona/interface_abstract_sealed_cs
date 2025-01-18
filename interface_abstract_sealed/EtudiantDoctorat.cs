namespace interface_abstract_sealed;

public sealed class EtudiantDoctorat : Etudiant
{
    private string theseDoctorat;

    public EtudiantDoctorat(string nom , int age , string theseDoctorat) : base(nom , age , "doctorat")
    {
        this.theseDoctorat = theseDoctorat;
    }

    public override void etudier()
    {
        Console.WriteLine(nom + " etudie sa these sur le sujet : " + theseDoctorat);
    }

    public override void passerExamen()
    {
        Console.WriteLine(nom + " passe une soutenance de these");
    }

    public override void afficherDetails()
    {
        Console.WriteLine("nom : " +nom +"\n"+"age : "+ age +"\n"+"these de doctorat : " + theseDoctorat);
    }
}