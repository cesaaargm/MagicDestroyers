namespace MagicDestroyers.Equipment.Weapons;

public class Axe : Weapon
{
    public Axe()
    {
    }

    public Axe(int damage, string? ability) : base(damage, ability)
    {
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }
}