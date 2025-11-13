using Microsoft.AspNetCore.WebUtilities;

public class Glass : IMaterial
{
	public float Durability { get; set; } = 20;

	public void Visit(Knife knife)
	{
		Durability -= knife.Damage * 0.2f;
	}

	public void Visit(Gun gun)
	{
		Durability -= gun.Damage * 1.2f;
	}

}