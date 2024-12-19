namespace Nissens_liste_og_hans_hjelpere;

public class Factory
{
    public List<Helper> Helpers { get; set; }

    public Factory()
    {
        Helpers = new List<Helper>
        {
            new Elf("Alv1", "Dett er Alv nummer 1"),
            new Elf("Per", "Dett er Alv nummer 2"),
        };
    }

    public void ShowHelpers()
    {
        foreach (var helper in Helpers)
        {
            helper.ShowInfo();
        }
    }
}