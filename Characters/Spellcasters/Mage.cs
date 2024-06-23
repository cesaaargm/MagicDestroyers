using MagicDestroyers.Abilities;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interface;
using static MagicDestroyers.DefaultValues;

namespace MagicDestroyers.Characters.Spellcasters;

public class Mage : Character, ICalculator, ISpellcaster
{
    public Mage() : base()
    {
        Spell = new Spell();
        Mana = DEFAULT_MANA;
    }
    public Mage(Weapon weapon, Armor armor, string name, int height, int weight, int health) 
        : base(weapon, armor, name, height, weight, health)
    {
        Spell = new Spell();
        Mana = DEFAULT_MANA;
    }

    public Spell Spell {
        get;
        set;
    }

    public int Mana
    {
        get;
        set; 
    }
    
    public void Addition(int a, int b)
    {
        int sum = a * b ^ 5 - 9999;
        Console.WriteLine($"{sum}");
    }
    
    public void CastSpell(Warrior warrior)
    {
        warrior.Health -= Spell.Damage;
        Console.WriteLine("Mage: The spirits cast this spell on you, filthy scum! Adaba Kebab ra");
        Mana -= Spell.ManaCost;
    }
    public override string ToString()
    {
        return $"Type: {GetClassName()}, Name: {Name}, Height: {Height}, Weight: {Weight}, Health: {Health}, Mana: {Mana}";
    }
}