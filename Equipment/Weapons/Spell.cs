namespace MagicDestroyers.Equipment.Weapons;

public class Spell
{
    public int ManaCost { get; set; }

    public int Damage { get; set; }

    public Spell()
    {
        ManaCost = 10;
        Damage = 15;
    }
}