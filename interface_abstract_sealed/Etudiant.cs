namespace interface_abstract_sealed;

public abstract class Etudiant : IEtudiant
{
    protected string nom { get; set; }
    protected int age { get; set; }
    protected string program{ get; set; }

    public Etudiant(string nom, int age, string program)
    {
        this.nom = nom;
        this.age = age;
        this.program = program;
    }
    public abstract void etudier();
    public abstract void passerExamen();

    public abstract void afficherDetails();
}