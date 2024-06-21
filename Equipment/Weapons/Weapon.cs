namespace MagicDestroyers.Equipment.Weapons;

public abstract class Weapon
{
    public Weapon()
    {
        
    }

    public Weapon(int damage, string? ability)
    {
        Damage = damage;
        Ability = ability;
    }

    public int Damage { get; set; }

    public string? Ability { get; set; }

    public abstract void Attack();
}