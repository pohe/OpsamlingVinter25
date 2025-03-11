using OpsamlingVinter25.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Models
{
	public class MenuItem : IMenuItem, IComparable<IMenuItem>
	{
		
		private int _no;
		public MenuItem(int no)
		{
			
			_no = no;
		}
		public MenuItem(int no, string name, double price, string description, MenuType menuType)
		{
			Name = name;
			Price = price;
			Description = description;
			TheMenuType = menuType;
			_no = no;
		}
		//TODO
		public string Description { get; set; }
		public string Name { get; set; }
		public int No { get { return _no; } }

		public double Price { get; set; }
		public MenuType TheMenuType { get; set; }

		public int CompareTo(IMenuItem? other)
		{
			if (other != null)
			{
				if (No < other.No)
					return -1;
				else if (No > other.No)
					return 1;
				else
					return 0;
			}
			else return 1; 
		}



		#region Methods
		public override string ToString()
		{
			return $"Nr {No} Navn {Name} Beskrivelse {Description} Price {Price} MenuType {TheMenuType.ToString()}";
		}


		#endregion
	}
}
