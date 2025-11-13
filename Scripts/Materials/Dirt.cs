public class Dirt : IMaterial
{
	public float Durability { get; set; } = 50;

	public void Visit(Knife knife)
	{
		Durability -= knife.Damage * 0.2f;
	}

	public void Visit(Gun gun)
	{
		Durability -= gun.Damage * 0.1f;
	}

	public void Visit(RPG rpg)
	{
		Durability -= rpg.Damage * 0.5f;
	}
}