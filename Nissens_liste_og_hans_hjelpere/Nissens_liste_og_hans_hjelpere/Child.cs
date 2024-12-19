namespace Nissens_liste_og_hans_hjelpere;

public class Child
{
    public string Name { get; private set; }
    public bool IsGood { get; private set; }
    public List<string> Wish { get; private set; }

    public Child(string name, bool isGood, List<string> wish)
    {
        Name = name;
        IsGood = isGood;
        Wish = wish;
    }
}

