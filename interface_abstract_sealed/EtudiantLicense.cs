namespace interface_abstract_sealed;

public class EtudiantLicense : Etudiant
{
    private int creditObtenus {get; set;}

    public EtudiantLicense(string nom, int age, int creditObtenus) : base(nom, age, "license")
    {
        this.creditObtenus = creditObtenus;
    }

    public override void etudier()
    {
        Console.WriteLine(nom + " etudie pour ses cours de license");
    }

    public override void passerExamen()
    {
        Console.WriteLine(nom + " passe ses examens de license");
    }
}