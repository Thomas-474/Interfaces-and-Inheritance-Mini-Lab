using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Inheritance_Mini_Lab
{
	class Program
	{
		/* Interface & Inheritance Class Layout:
			Food & IMexican   >   Taco
			Food & IMexican   >   Burrito
			Food	 >   HotDog
		*/
		public static void Main(string[] args)
		{
			Taco taco_1 = new Taco("soft", "chicken");
			Console.WriteLine(taco_1.Description());

			Taco taco_2 = new Taco("hard", "ground beef");
			Console.WriteLine(taco_2.Description());

			Burrito burrito_1 = new Burrito("spicy", "beef", "black");
			Console.WriteLine(burrito_1.Description());

			Burrito burrito_2 = new Burrito("regular", "chicken", "pinto");
			Console.WriteLine(burrito_2.Description());

			Hotdog hotdog_1 = new Hotdog("white", "ketchup");
			Console.WriteLine(hotdog_1.Description());

			Hotdog hotdog_2 = new Hotdog("pretzel", "mustard");
			Console.WriteLine(hotdog_2.Description());

			Console.ReadLine();
		}
	}
}
