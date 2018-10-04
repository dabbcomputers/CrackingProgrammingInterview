using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Fundamentals
{
	class ApproximationSquareRoot
	{
		public static double FindSquareRoot(int N)
		{
			int c = 1;
			while(c*c <= N)
			{
				c *= 2;
			}
			int a = 0;
			while(c != 1)
			{
				c = c / 2;
				if ((a + c) * (a + c) <= N)
					a = a + c;
			}
			return a;
		}
	}
}
