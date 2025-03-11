using OpsamlingVinter25.Data;
using OpsamlingVinter25.Interfaces;
using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Services
{
	public class CustomerRepository : IRepository<ICustomer>
	{
		private List<Interfaces.ICustomer> _customerList;

		public CustomerRepository()
		{
			_customerList = MockData.CustomerData;
		}
		public int Count => throw new NotImplementedException();

		public void AddItem(ICustomer item)
		{
			throw new NotImplementedException();
		}

		public List<ICustomer> GetAll()
		{
			throw new NotImplementedException();
		}

		public ICustomer? GetItemByNo(int no)
		{
			throw new NotImplementedException();
		}

		public void PrintAllItems()
		{
			throw new NotImplementedException();
		}

		public void RemoveItem(int no)
		{
			throw new NotImplementedException();
		}

		public void UpdatItem(ICustomer item)
		{
			throw new NotImplementedException();
		}
	}
}
