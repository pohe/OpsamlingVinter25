using OpsamlingVinter25.Data;
using OpsamlingVinter25.Exceptions;
using OpsamlingVinter25.Interfaces;
using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Services
{
	public class MenuItemRepository : IRepository<IMenuItem>, IMenuItemsFunctions
	{
		private List<IMenuItem> _menuItemList;

		public MenuItemRepository()
		{
			_menuItemList = MockData.MenuItemData;
		}

		public int Count { get { return _menuItemList.Count; } }
		

		public void AddItem(IMenuItem item)
		{
			_menuItemList.Add(item);
		}

		public List<IMenuItem> GetAll()
		{
			return _menuItemList;
		}
		public IMenuItem? GetItemByNo(int no)
		{
			IMenuItem? foundItem = _menuItemList.Find(i => i.No == no);
			if (foundItem == null)
				throw new ItemNotFoundException("Item not found");
			return foundItem;
		}


		public void PrintAllItems()
		{
			foreach (MenuItem menuItem in _menuItemList)
			{
				Console.WriteLine(menuItem);
			}
		}
		public void RemoveItem(int no)
		{
			IMenuItem? foundItem = _menuItemList.Find(i => i.No == no);
			if (foundItem != null)
			{
				_menuItemList.Remove(foundItem);
			}
			else
			{
				throw new ItemNotFoundException("Not found");
			}
		}
		public void UpdatItem(IMenuItem item)
		{
			int foundIndex = _menuItemList.FindIndex(i => i.No == item.No);
			if (foundIndex != -1)
			{
				_menuItemList[foundIndex] = item;
			}
			else
			{
				throw new ItemNotFoundException("Not found");
			}
		}

		public IMenuItem? FindItemCheaperThan(double price)
		{
			return _menuItemList.Find(i => i.Price < price);
		}
		public List<IMenuItem> FilterMenuItemsByMenuType(MenuType mType)
		{
			List<IMenuItem> foundItemsByMenuType = new List<IMenuItem>();
			if (_menuItemList != null)
				foundItemsByMenuType = _menuItemList.FindAll(i => i.TheMenuType == mType);
			return foundItemsByMenuType;
		}

		public List<IMenuItem> FilterMenuItemsByName(string filterCriteria)
		{
			List<IMenuItem> foundItemsByName = new List<IMenuItem>();
			if (_menuItemList != null)
				foundItemsByName = _menuItemList.FindAll(i => i.Name.Contains(filterCriteria));
			return foundItemsByName;
		}

		public int FindNumberMenuItemsCheaperThan(double price)
		{
			return _menuItemList.FindAll(i => i.Price < price).Count;
		}

		public double? AverageMenuItemPrice()
		{
			return _menuItemList.Average(i => i.Price);
		}
		public List<string> AllMenuItemNames()
		{
			return _menuItemList.Select( i=> i.Name).ToList(); 
		}

		public double? AverageMenuItemPriceForMenuType(MenuType mType)
		{
			return _menuItemList.FindAll(i => i.TheMenuType == mType).Average(y => y.Price);
		}

		
		public bool MenuItemNoExist(int no)
		{
			return _menuItemList.Any(i => i.No == no); 
		}

		public IMenuItem? MostExpensiveMenuItem()
		{
			IMenuItem mostExpensiveItem = _menuItemList.OrderByDescending(item => item.Price).FirstOrDefault();
			return mostExpensiveItem;  
		}

		public void PrintAllForeach()
		{
			_menuItemList.ForEach(i => Console.WriteLine(i.ToString())); 
		}

		

		public double TotalCostAllMenuItems()
		{
			return _menuItemList.Sum(i => i.Price);
		}

		
	}
}
