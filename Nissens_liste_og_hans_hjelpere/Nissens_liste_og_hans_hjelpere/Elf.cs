namespace Nissens_liste_og_hans_hjelpere;

public class Elf : Helper
{
    public List<string> Abilities { get; private set; }

    public Elf(string name, string description, List<string> abilities) : base(name, description)
    {
        Abilities = abilities;
    }
}
