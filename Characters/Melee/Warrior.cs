using MagicDestroyers.Abilities;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interface;

namespace MagicDestroyers.Characters.Melee;

public class Warrior : Character, ICalculator
{
    public Warrior(Weapon weapon, Armor armor, string name, int height, int weight) 
        : base(weapon, armor, name, height, weight)
    {
        Console.WriteLine($"Created a warrior.");
    }

    public void Addition(int a, int b)
    {
        Console.WriteLine($" {a + b}");
    }
    
}