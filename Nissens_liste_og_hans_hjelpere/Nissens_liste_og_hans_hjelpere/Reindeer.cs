namespace Nissens_liste_og_hans_hjelpere;

public class Reindeer : Helper
{
    public bool GlowingNose { get; private set; }

    public Reindeer(string name, string description, bool glowingNose) : base(name, description)
    {
        GlowingNose = glowingNose;
    }
}
