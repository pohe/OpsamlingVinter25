using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Interfaces
{
	public interface IMenuItemsFunctions
	{

		/// <summary>
		/// Finder det dyreste MenuItem
		/// </summary>
		/// <returns></returns>
		public IMenuItem? MostExpensiveMenuItem();

		/// <summary>
		/// Finder alle MenuItems som indeholder filtercriteria i name propertien
		/// </summary>
		/// <param name="filterCriteria"></param>
		/// <returns></returns>
		public List<IMenuItem> FilterMenuItemsByName(string filterCriteria);

		/// <summary>
		/// Finder alle menuItems af en given menuType
		/// </summary>
		/// <param name="mType"></param>
		/// <returns></returns>
		public List<IMenuItem> FilterMenuItemsByMenuType(MenuType mType);

		/// <summary>
		/// Finder average af alle menuitms price
		/// </summary>
		/// <returns></returns>
		double? AverageMenuItemPrice();
		
		/// <summary>
		/// Finder gennemsnittet for alle menuitems af en given menutype
		/// </summary>
		/// <param name="mType"></param>
		/// <returns></returns>
		double? AverageMenuItemPriceForMenuType(MenuType mType);

		/// <summary>
		/// Finder et menuitem der er billigere end en given price
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>
		IMenuItem? FindItemCheaperThan(double price);

		/// <summary>
		/// Finder antallet af menuitems der er billigere end en given pris
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>

		int FindNumberMenuItemsCheaperThan(double price);

		/// <summary>
		/// Finder ud af om der eksisterer et menuitem med et givent nummer
		/// </summary>
		/// <param name="no"></param>
		/// <returns></returns>
		bool MenuItemNoExist(int no);

		/// <summary>
		/// Returnerer en liste af alle names i listen af menuitems
		/// </summary>
		/// <returns></returns>
		List<string> AllMenuItemNames();

		/// <summary>
		/// Udskriver alle menuitems
		/// </summary>
		void PrintAllForeach();

		/// <summary>
		/// Beregner totalcost (summen af alle priser) for alle menuitems
		/// </summary>
		/// <returns></returns>

		double TotalCostAllMenuItems(); 

	}
}
