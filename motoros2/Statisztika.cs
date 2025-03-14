using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motoros2
{
	internal class Statisztika
	{
		List<Motor> motoros = [];


		public void ReadFromFile(string fileName, List<Motor> motoros)
		{
			StreamReader sr = new StreamReader(fileName);
			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] item = sor.Split(";");

				motoros.Add(new(item[0], item[1], Convert.ToInt16(item[2]), Convert.ToDouble(item[3],CultureInfo.InvariantCulture), Convert.ToDouble(item[4], CultureInfo.InvariantCulture)));
				

			}
		}
		

		public void ItemsOut(List<Motor> motoros)
		{
			foreach(var item in motoros)
			{
				Console.WriteLine(item.Brand + " " + item.Name + " " + item.ReleaseYear + " " + item.Performance + " " + item.PriceInEuro);
			}
		}

		public void SumPrices(List<Motor> motoros)
		{
			double allPrice = 0;
			for (int i = 0; i < motoros.Count; i++)
			{
				
				allPrice += motoros[i].PriceInEuro;

				
			}
			Console.WriteLine(allPrice);

		}

		public bool Contain(string search, List<Motor> motoros)
		{
			foreach (var item in motoros)
			{
				if (item.Brand == search)
				{
					return true;
				}
			}
			return false;
		}

		public void Oldest(List<Motor> motoros)
		{
			int year1 = motoros[0].ReleaseYear;
			int year2 = motoros[0].ReleaseYear;

			for (int i = 1; i < motoros.Count; i++)
			{
				if (motoros[i].ReleaseYear < year1)
				{
					year1 = motoros[i].ReleaseYear;
				}
				if (motoros[i].ReleaseYear > year2)
				{
					year2 = motoros[i].ReleaseYear;
					Console.WriteLine();
				}
			}
			Console.WriteLine(year1);
			Console.WriteLine(year2);
		}




		

	}
}
