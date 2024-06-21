namespace MagicDestroyers.Equipment.Weapons;

public class Sword : Weapon
{
    public Sword() : base()
    {
    }
    public Sword(int damage, string? ability) : base(damage, ability)
    {
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }
}