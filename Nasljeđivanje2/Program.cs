using System;

namespace Nasljedivanje2
{
    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }

    }
    class ProceduralniJezik : ProgramskiJezik { }
    class ObjektniJezik : ProgramskiJezik { }
    class FunkcionalniJezik : ProgramskiJezik { }

    internal class Program
    {
        static void Main(string[] args)
        {
            double zbroj;
            ProceduralniJezik x = new ProceduralniJezik();
            ObjektniJezik y = new ObjektniJezik();
            FunkcionalniJezik z = new FunkcionalniJezik();

            Console.WriteLine("Upišite x: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite y: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite z: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());

            zbroj = x.Postotak + y.Postotak + z.Postotak;

            if (zbroj != 100) Console.WriteLine("Neispravan unos podataka");
            else if (zbroj == 100)
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak) Console.WriteLine("Najveci postotak ima procedurarlno sa: " + x.Postotak);
                if (y.Postotak > x.Postotak && y.Postotak > z.Postotak) Console.WriteLine("Najveci postotak ima Objektno sa: " + y.Postotak);
                if (z.Postotak > y.Postotak && z.Postotak > x.Postotak) Console.WriteLine("Najveci postotak ima Funkcionalno sa: " + z.Postotak);

            }

            Console.ReadKey();
        }

    }

}

