using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Mammals.Cats
{
    public class Cat : Mammal
    {
        public Cat()
        {
            Limbs = 4;
            MammaryGlands = 6;
            BornDateTime = DateTime.Now;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Miau");
        }
    }
}
