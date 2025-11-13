public class Knife : IWeapon
{
	public int Damage { get; set; } = 10;

	public void Hit(IMaterial material)
	{
		material.Visit(this);
	}
}