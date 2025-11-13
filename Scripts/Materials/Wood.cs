public class Wood : IMaterial
{
	public float Durability { get; set; } = 100;

	public void Visit(Knife knife)
	{
		Durability -= knife.Damage * 0.1f;
	}

	public void Visit(Gun gun)
	{
		Durability -= gun.Damage * .4f;
	}

}