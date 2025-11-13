using System.Security.Cryptography;

public interface IMaterial
{
	public float Durability { get; set; }
	
	public virtual void Visit(Knife knife)
	{
		Durability -= knife.Damage;
	}
	public virtual void Visit(Gun gun)
	{
		Durability -= gun.Damage;
	}
	public virtual void Visit(RPG rpg)
	{
		Durability -= rpg.Damage;
	}
}