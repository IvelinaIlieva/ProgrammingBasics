using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPackageForDogs = int.Parse(Console.ReadLine());
            int countPackageForCats = int.Parse(Console.ReadLine());
            double pricePackageForDog = countPackageForDogs * 2.50;
            int pricePackageForCat = countPackageForCats * 4;
            double sum = pricePackageForCat + pricePackageForDog;

            Console.WriteLine(sum + " lv.");
        }
    }
}
