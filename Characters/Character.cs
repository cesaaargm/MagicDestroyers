using MagicDestroyers.Abilities;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using static MagicDestroyers.DefaultValues;

namespace MagicDestroyers.Characters;

public abstract class Character
{
    public Character()
    {
        Name = "Character" + new Random().Next(1, 101).ToString();
        Weight = new Random().Next(80, 120);
        Height = new Random().Next(150, 210);
        Weapon = WeaponFactory.CreateWeapon(this);
        Armor = null; //new Armor(); // TODO ArmorFactory
        Ability = null; // new Ability(); // TODO AbilityFactory
    }
    public Character(Weapon weapon, Armor armor, Ability ability, string name, int height, int weight, int health = DEFAULT_HEALTH)
    {
        Name = name;
        Weight = weight;
        Height = height;
        Weapon = weapon;
        Armor = armor;
        Ability = ability;
    }

    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    private int _age = 0;
    public int Age
    {
        get => _age;
        set
        {
            if (value is >= MIN_AGE and <= MAX_AGE)
            {
                _age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Empty, $@"Age not allowed. Setting default age ({DEFAULT_AGE}) instead.");
            }
        }
    }

    public int Health { get; set; }

    public Weapon Weapon {
        get;
        set;
    } 
    public Armor Armor { get; set; }
    public Ability Ability { get; set; }
    public void Greetings(Character character)
    {
        Console.WriteLine($"Hello {character.Name}! I am {this.Name}, and I am ready for the adventure!");
    }
    
    public string GetClassName()
    {
        return this.GetType().Name;
    }
    public override string ToString()
    {
        return $"Type: {GetClassName()}, Name: {Name}, Height: {Height}, Weight: {Weight}, Health: {Health}";
    }
}