using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Inheritance_Mini_Lab
{
	class Burrito : Food, IMexican
	{
		public string shell
		{ get; set; }

		public string meat
		{ get; set; }

		public string beans
		{ get; set; }

		public Burrito(string Shell, string Meat, string Beans)
		{
			shell = Shell;
			meat = Meat;
			beans = Beans;
			price = 4.99M;
		}

		public override string Description()
		{
			return $"This burrito has a {shell} tortilla shell, {meat}, and {beans} beans. It costs ${price}.";
		}
	}
}
