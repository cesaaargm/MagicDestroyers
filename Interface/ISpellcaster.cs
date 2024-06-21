using MagicDestroyers.Characters.Melee;

namespace MagicDestroyers.Interface;

interface ISpellcaster
{
    int Mana { get; set; }

    void CastSpell(Warrior warrior);
}