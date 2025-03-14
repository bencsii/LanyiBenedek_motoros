namespace motoros2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<Motor> motoros = new List<Motor>();

			Statisztika stat1 = new Statisztika();

			stat1.ReadFromFile("motors.txt", motoros);
			stat1.ItemsOut(motoros);
		}
	}
}
