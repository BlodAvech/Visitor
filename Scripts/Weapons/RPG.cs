public class RPG : IWeapon 
{
	public void Visit(Glass glass)
	{
		Console.WriteLine("Стекло разлетелось");
	}

	public void Visit(Wood wood)
	{
		Console.WriteLine("Дерево разлетелось в щепки");
	}

	public void Visit(Dirt dirt)
	{
		Console.WriteLine("Получился окоп");
	}
}