using OpsamlingVinter25.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Helpers
{
	public class CompareMenuItemByPrice : IComparer<IMenuItem>
	{
		public int Compare(IMenuItem? x, IMenuItem? y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			//if ( x!= null && y!= null)
			//{
			//	if (x.Price < y.Price)
			//		return -1;
			//	else if (x.Price > y.Price)
			//		return 1;
			//	else
			//		return 0;
			//}
			//return 0; 
			return x.Price.CompareTo(y.Price);
		}
	}
}
