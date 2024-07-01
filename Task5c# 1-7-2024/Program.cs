using System;


namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars carsinfo = new Cars();
            //Console.WriteLine(carsinfo.Type);
            //Console.WriteLine(carsinfo.Year);
            //Console.WriteLine(carsinfo.Model);
            //Console.WriteLine(carsinfo.PalletNo);
            //Console.WriteLine(carsinfo.Color);
            //Console.WriteLine(carsinfo.Price);
            //Console.WriteLine(carsinfo.StopEngine());


            //Console.WriteLine(carsinfo.InformationCar());

            //Cars carsinfo = new Cars( "Mercedec", "sonata", "Red", "100000$", 52225, 2025);
            //Console.WriteLine( carsinfo.Type);


            BMW bmw = new BMW("Mercedec", "FSA", "Red", "100000$", 52225, 2030);
            Console.WriteLine(bmw.Type);
            Console.WriteLine(bmw.InformationCar());
            Console.WriteLine(bmw.StartEngine());
        }
    }
}