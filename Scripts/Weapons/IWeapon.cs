public interface IWeapon
{
	public int Damage { get; }
	public abstract void Hit(IMaterial material);
}