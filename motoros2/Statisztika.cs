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
	}
}
