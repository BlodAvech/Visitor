
List<IWeapon> weapons = new List<IWeapon>() { new Knife(), new Gun(), new RPG() };
List<IMaterial> materials = new List<IMaterial>() { new Glass(), new Wood(), new Dirt() };

foreach(IMaterial material in materials)
{
	foreach(IWeapon weapon in weapons)
	{
		Console.WriteLine(material);
		Console.WriteLine(weapon);
		System.Console.WriteLine(material.Durability);
		weapon.Hit(material);
		System.Console.WriteLine(material.Durability);
		Console.WriteLine();
	}
}