using System;
using System.Collections.Generic;
using System.Text;

namespace KlasaAbstrakcyjna
{
    class Kwadrat : Figura
    {
        public double A { get; private set; }

        public Kwadrat(double a)
        {
            A=a;
        }

        public override double obwod()
        {
            return 4 * A;
        }

        public override double pole()
        {
            return A * A;
        }

        public double przekatna()
        {
            return Math.Sqrt(2)*A;
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Jestem Kwadrat :)");
            base.Wyswietl();
            Console.WriteLine($"Przekatna {przekatna()}");
        }
    }
}
