using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nissens_liste_og_hans_hjelpere
{
    class Elf : Helper
    {
      public string Description { get; set; }

      public Elf(string name, string description) : base(name)
      {
          Description = description;
      }
    }
}
