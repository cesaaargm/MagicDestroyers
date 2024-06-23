using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Interface;

interface ISpellcaster
{
    int Mana { get; set; }

    void CastSpell(Warrior warrior);

    public Spell Spell { get; set; }
}