using OpsamlingVinter25.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Models
{
	public class Customer : ICustomer
	{
		private int _id;
				
		public string Address { get; set; }
		public bool ClubMember { get; set; }
		public int Id { get { return _id; } set { _id = value; } }

		public string Mobile { get; set; }

		public string Name { get; set; }

		public Customer(int id, string name, string mobile, string address)
		{
			_id = id;
			Name = name;
			Mobile = mobile;
			Address = address;
			ClubMember = false;
		}
		#region Methods
		public override string ToString()
		{
			return $"{_id} {Name} {Mobile} {Address} {(ClubMember ? "er medlem" : "Er ikke medlem")}";
		}
		#endregion
	}
}
