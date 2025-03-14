﻿using OpsamlingVinter25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingVinter25.Interfaces
{
	public interface IMenuItem
	{
		string Description { get; set; }
		string Name { get; set; }
		int No { get; }
		double Price { get; set; }
		MenuType TheMenuType { get; set; }
		string ToString();

	}
}
