// See https://aka.ms/new-console-template for more information

using MagicDestroyers.Abilities;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;


// create two warriors, greet them
Warrior goodWarrior = new Warrior(new Axe(43, ""), new ClothRobe(protection: 80), "Maik", 190, 80);
try
{
    // code that may raise exception
    goodWarrior.Age = 99;
    goodWarrior.Addition(1,2);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


Warrior badWarrior = new Warrior(new Axe(43, ""), new ClothRobe(protection: 80), "John", 199, 89);

goodWarrior.Greetings(badWarrior);
badWarrior.Greetings(goodWarrior);


// create a mage, make him cast a spell on a warrior.
Mage firstMage = new Mage();
Console.WriteLine();
Console.WriteLine($"Status before the spell:");
Console.WriteLine(firstMage.ToString());
Console.WriteLine(goodWarrior.ToString());
Console.WriteLine($"-----------------------------");
firstMage.CastSpell(goodWarrior);
Console.WriteLine(firstMage.ToString());
Console.WriteLine(goodWarrior.ToString());


