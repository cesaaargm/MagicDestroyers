using MagicDestroyers.Abilities;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters;

public class Necromancer(Weapon weapon, Armor armor, Ability ability, string name, int height, int weight, int health)
    : Character(weapon, armor, ability, name, height, weight, health)
{
    
}