public class Gun : IWeapon
{
	public void Visit(Glass glass)
	{
		Console.WriteLine("Стекло разбилось");
	}

	public void Visit(Wood wood)
	{
		Console.WriteLine("Дерево треснуло");
	}

	public void Visit(Dirt dirt)
	{
		Console.WriteLine("Ничего не случилось");
	}
}