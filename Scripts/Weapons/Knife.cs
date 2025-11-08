public class Knife : IWeapon
{
	public void Visit(Glass glass)
	{
		Console.WriteLine("Стекло поцарапалось");
	}

	public void Visit(Wood wood)
	{
		Console.WriteLine("Дерево получило вмятину");
	}

	public void Visit(Dirt dirt)
	{
		Console.WriteLine("Ничего не случилось");
	}
}