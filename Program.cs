
List<IWeapon> weapons = new List<IWeapon>() { new Knife(), new Gun(), new RPG() };
List<IMaterial> materials = new List<IMaterial>() { new Glass(), new Wood(), new Dirt() };

foreach(IMaterial material in materials)
{
	foreach(IWeapon weapon in weapons)
	{
		Console.WriteLine(material);
		Console.WriteLine(weapon);
		material.Accept(weapon);
		Console.WriteLine();
	}
}