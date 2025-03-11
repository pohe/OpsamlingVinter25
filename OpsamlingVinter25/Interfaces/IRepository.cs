using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Interfaces
{
	public interface IRepository<T>
	{
		int Count { get; }
		List<T> GetAll();
		void AddItem(T item);
		T? GetItemByNo(int no);
		void RemoveItem(int no);
		void UpdatItem(T item);
		void PrintAllItems();
	}
}
