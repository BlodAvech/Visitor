public interface IWeapon 
{
	public abstract void Visit(Glass glass);
	public abstract void Visit(Wood wood);
	public abstract void Visit(Dirt dirt);
}