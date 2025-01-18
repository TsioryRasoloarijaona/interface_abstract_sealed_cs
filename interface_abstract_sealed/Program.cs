// See https://aka.ms/new-console-template for more information


using interface_abstract_sealed;

public class Program()
{
    public static void Main(string [] args)
    {
        EtudiantLicense license = new EtudiantLicense("james ", 20, 58);
        Console.WriteLine("**************************************");
        Console.WriteLine("etudiant en licence");
        license.etudier();
        license.passerExamen();
        EtudiantMaster master = new EtudiantMaster("carl", 24, "space biology");
        Console.WriteLine("**************************************");
        Console.WriteLine("etudiant en master");
        master.etudier();
        master.passerExamen();
        EtudiantDoctorat doctorat = new EtudiantDoctorat("carole", 28, "cord theory");
        Console.WriteLine("**************************************");
        Console.WriteLine("etudiant en doctorat");
        doctorat.etudier();
        doctorat.passerExamen();
    }
}
