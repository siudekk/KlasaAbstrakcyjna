using System;

namespace KlasaAbstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {           
            Kwadrat K1 = new Kwadrat(2);

            K1.Wyswietl();

            Kolo KO1 = new Kolo(2);

            KO1.Wyswietl();

            Figura[] figury = new Figura[3];

            figury[0] = new Kwadrat(2);
            figury[1] = new Kolo(2);
            figury[2] = new Kwadrat(3);

            foreach (Figura figura in figury)
            {
                figura.Wyswietl();
            }

            Console.ReadKey();
        }
    }
}
