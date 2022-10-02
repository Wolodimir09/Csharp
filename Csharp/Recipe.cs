using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Recipe
    {
        public string Name { get; set; }
        public string NameKithen { get; set; }
        public string[] NameIngredients { get; set; }
        public DateTime CookingTime { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{"Назва рецепту:",15} {Name,-15}\n" +
                   $"{"Назва кухні:",15} {NameKithen,-15}\n" +
                   $"{"Список інгредієнтів:",15} {NameIngredients.Where(e => e != null).GetEnumerator(),-15}\n" +
                   $"{"Час приготування:",15} {CookingTime,-15}\n" +
                   $"{"Покроковий опис:",15} {Description,-200}\n";
                ;
        }

    }
}
