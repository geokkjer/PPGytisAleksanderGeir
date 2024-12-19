namespace Nissens_liste_og_hans_hjelpere;

public class Factory
{
    public List<Helper> Helpers { get; set; }
    public List<Child> Children { get; set; }

    public Factory()
    {
        Helpers = new List<Helper>
        {
            new Elf("Alvin", "Dette er Alv nummer 1", ["building toys", "help santa", "wrap gifts"]),
            new Elf("Alven", "Dette er Alv nummer 2",  ["building toys", "help santa", "wrap gifts"]),
            new Elf("Greg", "Dette er Alv nummer 3", ["building toys", "help santa", "wrap gifts"]),
            new Elf("Hombre", "Dette er Alv nummer 4", ["building toys", "help santa", "wrap gifts"]),

            new Reindeer("Rudolph", "Santa's guiding light.", true),
            new Reindeer("Dasher", "The fast onel.", false),
            new Reindeer("Dancer", "The groovy one.", false),
            new Reindeer("Prancer", "The group rouser.", false),
            new Reindeer("Vixen", "The entertainer.", false),
        };

        Children = new List<Child>
        {
            new Child("Miguel", false, ["white BMW", "Weed", "Cupcakes"]),
            new Child("William", true, ["Bitches", "Heroin", "Bad Dragon TM Dildo"]),
            new Child("Geir", true, ["Stabil datamaskin", "Meth", "Waffler"]),
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
