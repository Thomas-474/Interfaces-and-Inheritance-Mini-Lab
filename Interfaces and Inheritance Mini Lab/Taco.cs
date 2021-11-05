using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Inheritance_Mini_Lab
{
	class Taco : Food, IMexican
	{
		public string shell
		{ get; set; }

		public string meat
		{ get; set; }

		public Taco(string Shell, string Meat)
		{
			shell = Shell;
			meat = Meat;
			price = 3.25M;
		}

		public override string Description()
		{
			return $"This taco has a {shell} shell and {meat}. It costs ${price}.";
		}
	}
}
