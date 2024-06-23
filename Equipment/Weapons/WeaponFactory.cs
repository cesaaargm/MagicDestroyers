using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers.Equipment.Weapons;

public static class WeaponFactory
{
    public static Weapon CreateWeapon(Character character)
    {
        switch (character)
        {
            case Assassin:
                return new Sword();
            case Knight:
                return new Hammer();
            case Warrior:
                return new Axe();
            case Druid:
                return new Staff();
            case Mage:
                return new Staff();
            case Necromancer:
                return new Sword();
            default:
                return new Sword();

            
        }
    }
}