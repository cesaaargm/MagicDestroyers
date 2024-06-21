// See https://aka.ms/new-console-template for more information

using MagicDestroyers.Abilities;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;



Warrior goodWarrior = new Warrior(new Axe(43, ""), new ClothRobe(protection: 80), new Ability(), "Maik", 190, 80);
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

Warrior badWarrior = new Warrior(new Axe(43, ""), new ClothRobe(protection: 80), new Ability(), "John", 199, 89);

goodWarrior.Greetings(badWarrior);
badWarrior.Greetings(goodWarrior);


Mage firstMage = new Mage();
firstMage.CastSpell(goodWarrior);
Console.WriteLine(firstMage.ToString());
Console.WriteLine(goodWarrior.ToString());


