using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Mammals;
using Model.Mammals.Cats;
using Model.Mammals.Dogs;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //====== PET SHOP - Polimorfismo =======
            List<Animal> petShop;
            petShop = new List<Animal>
            {
                new Cat(),
                new Dog(),
                new Cat(),
                new Cat(),
                new Cat()
            };

            for (int i=0; i<petShop.Count; i++)
            {
                petShop[i].MakeNoise();
            }
            //=====================================

            Animal pet = new Dog();
            Dog toto = new Dog();

            toto.Jump();

            Console.ReadLine();//Aguarda o ENTER...
        }
    }
}
