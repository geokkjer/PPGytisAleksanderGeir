

namespace Nissens_liste_og_hans_hjelpere
{
    public class Helper
    {
        public string name { get; set; }
        

        public Helper(string name)
        {
            this.name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}");
        }
    }
}
