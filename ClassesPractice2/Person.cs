using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice2
{
    internal class Person
    {
        public Person(string name, string favoriteColor, string favoriteFood)
        {
            Name = name;
            FavoriteColor = favoriteColor;
            FavoriteFood = favoriteFood;
        }

        public string Name { get; set; }
        public string FavoriteColor { get; set; }

        public string FavoriteFood { get; set; }

        //The following DisplayInfo might be a violation of the Single Principle
        //This deals with UI and typically UI has a separate class
        internal void GetDisplayInfo()
        {
            string info = @$"
Name: {Name}
Favorite Color: {FavoriteColor}
Favorite Food: {FavoriteFood}
";
            Console.WriteLine(info);
        }
    }
}
