using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Inheritance_Mini_Lab
{
	class Hotdog : Food
	{
		public string topping
		{ get; set; }

		public string bun
		{ get; set; }

		public Hotdog(string Bun, string Topping)
		{
			bun = Bun;
			topping = Topping;
			price = 3.99M;
		}

		public override string Description()
		{
			return $"This hotdog has a {bun} bun and {topping}. It costs ${price}.";
		}
	}
}
