namespace Nissens_liste_og_hans_hjelpere
{
    public class Helper : IMagical
    {
        public string name { get; set; }
        public string description { get; private set; }

        public Helper(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}, {description}");
        }

        public void DoMagic()
        {
            Console.WriteLine($"{name} is performing magic!");
        }
    }

}
