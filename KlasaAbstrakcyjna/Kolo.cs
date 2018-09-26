using System;
using System.Collections.Generic;
using System.Text;

namespace KlasaAbstrakcyjna
{
    class Kolo : Figura
    {
        public double Promien { get; set; }

        public Kolo(double promien)
        {
            Promien = promien;
        }

        public override double obwod()
        {
            return 2*Math.PI * Promien;
        }

        public override double pole()
        {
            return Math.PI* Math.Pow(Promien, 2);
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Jestem Kolo :)");
            base.Wyswietl();
        }
    }
}
