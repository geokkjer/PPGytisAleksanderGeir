namespace Nissens_liste_og_hans_hjelpere;

public class Child
{
    bool IsGood { get; set; }
    List<string> Wish { get; set; }

    public Child(bool isGood, List<string> wish)
    {
        IsGood = isGood;
        Wish = wish;
    }
}

