namespace MagicDestroyers.Equipment.Weapons;

public class Staff : Weapon
{
    public Staff() : base()
    {
    }

    public Staff(int damage, string? ability) : base(damage, ability)
    {
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }
}