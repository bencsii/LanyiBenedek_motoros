namespace motoros2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<Motor> motoros = new List<Motor>();

			Statisztika stat1 = new Statisztika();

			stat1.ReadFromFile("motors.txt", motoros); // beolvasas

			
			Console.Write("Osszes motor erteke: ");
			stat1.SumPrices(motoros); // Az osszes motor osszerteke a listaban

			Console.Write("Tartalmaz e a lista ilyen motort? "); // van e ilyen motor
			stat1.Contain("Yamaha", motoros);
			Console.WriteLine(stat1.Contain("Yamaha", motoros)? "Brand found  Yamaha": "Not found");


			stat1.Oldest(motoros); //Visszadja a legregebbi motort a listaban


			Console.WriteLine("----------------------------------------------------------------");

			Console.WriteLine("Az elemek sort hasznalata elott: ");
            stat1.ItemsOut(motoros);

            stat1.Sort(motoros); // rendezes gyorsabb felul lassabb alul
			Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Elemek rendezve sorttal: ");
			stat1.ItemsOut(motoros);


			int basedOnBrand = stat1.SumPricesBasedOnBrand("Yamaha"); // int SumBasedOnBrand(string brandName)  hibas valamiert mindig csak 0 at ad vissza
            Console.WriteLine("Osszertek: " + basedOnBrand);



            

        }
	}
}
