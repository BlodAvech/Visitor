public class Wood : IMaterial
{
	public void Accept(IWeapon weapon)
	{
		weapon.Visit(this);
	}
}