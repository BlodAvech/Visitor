public class Gun : IWeapon
{
	public int Damage { get; set; } = 40;

	public void Hit(IMaterial material)
	{
		material.Visit(this);
	}
}