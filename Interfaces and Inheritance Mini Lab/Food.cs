using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Inheritance_Mini_Lab
{
	abstract class Food
	{
		public decimal price
		{ get; set; }

		public abstract string Description();
	}
}
