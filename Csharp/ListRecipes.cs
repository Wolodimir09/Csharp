using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class ListRecipes
    {
        private List<Recipe> recipes = new List<Recipe>();
        public Recipe this[int index]
        {
            get
            {
                if (index >= 0 && index < recipes.Count)
                {
                    return recipes[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                recipes[index] = value;
            }
        }

        public List<Recipe> Add()  // Додається новий рецепт
        {
            Console.Write("\n\tНазва рецепту: ");
            string name = Console.ReadLine();
            Console.Write("\tНазва кухні: ");
            string nameKithen = Console.ReadLine();
            Console.Write("\tНазва інгредієнтів: ");
            string[] nameIngredients = Console.ReadLine().Split();
            Console.Write("\tЧас приготування (HH:mm): ");
            DateTime cookingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm",
                                System.Globalization.CultureInfo.InvariantCulture);            
            Console.Write("\tОпис процесу приготування: ");
            string Description = Console.ReadLine();

            recipes.Add(new Recipe()
            {
                Name = name,
                NameKithen = nameKithen,
                NameIngredients = nameIngredients,
                CookingTime = cookingTime,
                Description = Description
            });
            return recipes;
        }
        public Recipe SearchName()
        {
            Console.Write("\tВведіть назву рецепта: ");
            string name = Console.ReadLine();            
            return recipes.Where(e=>e.Name==name).First();
        }
    }
}
