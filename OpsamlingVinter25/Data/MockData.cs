
using OpsamlingVinter25.Interfaces;
using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Data
{
	public static class MockData
	{
		#region Instance fields
		private static List<ICustomer> _customerData =
		new List<ICustomer>()
			{
			new Customer(1, "Mikkel", "12121212", "Street 123"),
			new Customer(2, "Charlotte", "13131313", "Avenue 321"),
			new Customer(3, "Carina", "14141414", "High Street 234"),
			new Customer(4, "Muhammed", "15151515", "North Street 345")
			};

		private static List<IMenuItem> _menuItemData =
			new List<IMenuItem>()
			{
			new MenuItem(1, "Margherita", 85, "Tomat, ost", MenuType.PIZZECLASSSICHE),
			new MenuItem(2, "Vesuvio", 95, "Tomat, ost & skinke", MenuType.PIZZECLASSSICHE),
			new MenuItem(3, "Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
			new MenuItem(4, "Calzone", 98, "Indbagt pizza med tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
			new MenuItem(5, "Quattro Stagioni", 98, "Tomat, ost, skinke, champignon, rejer & paprika", MenuType.PIZZECLASSSICHE),
			new MenuItem(6, "Marinara", 97, "Tomat, ost, rejer, muslinger & hvidløg", MenuType.PIZZECLASSSICHE),
			new MenuItem(7, "Vegetariana", 98, "Tomat, ost & grønsager", MenuType.PIZZECLASSSICHE),
			new MenuItem(8, "Italiana", 97, "Tomat, ost, løg & kødsauce", MenuType.PIZZECLASSSICHE)
			};

		#endregion
		#region Properties
		public static List<ICustomer> CustomerData
		{
			get { return _customerData; }
		}

		public static List<IMenuItem> MenuItemData
		{
			get { return _menuItemData; }
		}



		#endregion
	}
}
