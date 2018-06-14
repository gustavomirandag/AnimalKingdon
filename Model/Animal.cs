using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class Animal
    {
        public DateTime BornDateTime { get; set; }
        public int Limbs { get; set; } //Membros
        public abstract void MakeNoise();
    }
}
