namespace Nissens_liste_og_hans_hjelpere;

public static class Factory
{
    public static void Run()
    {
        var helpers = new List<Helper>
        {
            new Elf("Alv1", "Dett er Alv nummer 1"),
            new Elf("Per","Dett er Alv nummer 2")
        };


    }
}