using System;
using System.Collections.Generic;
using System.Text;

namespace KlasaAbstrakcyjna
{
    abstract class Figura
    {
        public abstract double pole();

        public abstract double obwod();

        public virtual void Wyswietl()
        {
            Console.WriteLine($"Pole {pole()}");
            Console.WriteLine($"Obwod {obwod()}");
        }
    }
}
