using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motoros2
{
	internal class Motor
	{
		string brand;
		string name;
		int releaseYear;
		double performance;
		double priceInEuro;

		public string Brand { get => brand; set => brand = value; }
		public string Name { get => name; set => name = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
		public double Performance { get => performance; set => performance = value; }
		public double PriceInEuro { get => priceInEuro; set => priceInEuro = value; }


		public Motor(string brand, string name, int releaseYear, double performance, double priceInEuro)
		{
			this.brand = brand;
			this.name = name;
			this.releaseYear = releaseYear;
			this.performance = performance;
			this.priceInEuro = priceInEuro;
		}


		

		
	}
}
