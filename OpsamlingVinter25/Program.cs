// See https://aka.ms/new-console-template for more information
using OpsamlingVinter25.Exceptions;
using OpsamlingVinter25.Interfaces;
using OpsamlingVinter25.Models;
using OpsamlingVinter25.Services;

Console.WriteLine("Opsamling vinter 2025");


MenuItemRepository menuRepo = new MenuItemRepository();

menuRepo.PrintAllItems();
try
{
	IMenuItem it1 = new MenuItem(9, "Sardine", 97, "Tomat, ost, Sardiner, løg", MenuType.PIZZECLASSSICHE);
	Console.WriteLine($"Antal menuItems før add {menuRepo.Count}");
	menuRepo.AddItem(it1);

	Console.WriteLine($"Antal menuItems efter add {menuRepo.Count}");

	IMenuItem foundItem = menuRepo.GetItemByNo(9);

	Console.WriteLine($"MenuItem 9 {foundItem}");

	menuRepo.UpdatItem(new MenuItem(9, "Sardine25", 100, "Tomat, ost, Sardiner, løg", MenuType.PIZZECLASSSICHE));

	Console.WriteLine($"Efter update {menuRepo.GetItemByNo(9)} ");

	menuRepo.RemoveItem(9);

	Console.WriteLine($"Antal efter remove af item No 9. Antal items {menuRepo.Count} ");
} catch (ItemNotFoundException infExp)
{
    Console.WriteLine( infExp.Message);
}
catch( Exception exp)
{
    Console.WriteLine("Generel error");
}


