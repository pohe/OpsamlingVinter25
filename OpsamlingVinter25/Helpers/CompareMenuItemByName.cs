using OpsamlingVinter25.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Helpers
{
	public class CompareMenuItemByName : IComparer<IMenuItem>
	{
		public int Compare(IMenuItem? x, IMenuItem? y)
		{
			return x.Name.CompareTo(y.Name); 
		}
	}
}
