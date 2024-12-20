namespace Nissens_liste_og_hans_hjelpere
{
    public class Helper : IMagical
    {
        public string name { get; set; }
        public string description { get; private set; }
        public string type { get; private set; }

        public Helper(string name, string description, string type)
        {
            this.name = name;
            this.description = description;
            this.type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Type: {type}, Name: {name}, {description}");
        }

        public void DoMagic()
        {
            Console.WriteLine($"{name} is performing magic!");
        }
    }

}
