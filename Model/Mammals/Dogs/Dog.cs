using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Mammals.Dogs
{
    public class Dog : Mammal
    {
        public Dog()
        {
            Limbs = 4;
            MammaryGlands = 6;
            BornDateTime = DateTime.Now;
        }

        public void Jump()
        {
            Console.WriteLine("Jump!");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Auau");
        }
    }
}
