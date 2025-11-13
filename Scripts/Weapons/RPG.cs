public class RPG : IWeapon
{
	public int Damage { get; set; } = 300;

	public void Hit(IMaterial material)
	{
		material.Visit(this);
	}
}