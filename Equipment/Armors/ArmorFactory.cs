using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Equipment.Armors;

public static class ArmorFactory
{
    public static Armor CreateArmor(Character character)
    {
        switch (character)
        {
            case Assassin:
                return new LightLeatherVest();
            case Knight:
                return new Chainlink();
            case Warrior:
                return new Chainlink();
            case Druid:
                return new LightLeatherVest();
            case Mage:
                return new ClothRobe();
            case Necromancer:
                return new LightLeatherVest();
            default:
                return new LightLeatherVest();

            
        }
    }
}