namespace Nissens_liste_og_hans_hjelpere;

public class Elf : Helper
{
    public List<string> Abilities { get; private set; }

    public Elf(string name, string description, string type, List<string> abilities) : base(name, description, type)
    {
        Abilities = abilities;
    }
}
