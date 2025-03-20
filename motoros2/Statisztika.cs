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
            
            for (int i = 0; i < motoros.Count - 1; i++)
            {
                for (int j = 0; j < motoros.Count - 1 - i; j++)
                {
                    if (motoros[j].ReleaseYear > motoros[j + 1].ReleaseYear)
                    {
                        
                        Motor temp = motoros[j];
                        motoros[j] = motoros[j + 1];
                        motoros[j + 1] = temp;
                    }
                }
            }
            Motor oldestMotor = motoros[0];
            
            Console.WriteLine($"A legregebbi motor: {oldestMotor.Brand} {oldestMotor.Name} ({oldestMotor.ReleaseYear})");
        }


        public int SumPricesBasedOnBrand(string brandName)
        {
            double sum = 0;

            for (int i = 0; i < motoros.Count; i++)
            {
                if (motoros[i].Brand == brandName)
                {
                    sum += motoros[i].PriceInEuro;
                }
            }

            return (int)sum;

        }


        public void Sort(List<Motor> motoros)
        {
            for (int i = motoros.Count; i > 0; i--)
            {
                for (int j = 0; j < motoros.Count - 1; j++)
                {
                    if (motoros[j].Performance < motoros[j + 1].Performance)
                    {
                        Motor temp = motoros[j];
						motoros[j] = motoros[j + 1];
                        motoros[j + 1] = temp;
                    }
                }
            }
        }






    }
}
