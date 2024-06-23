using MagicDestroyers.Abilities.Defensive;
using MagicDestroyers.Abilities.Offensive;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers.Abilities;

public static class AbilitiesFactory
{
    public static void CreateAbilitiesForCharacter(Character character)
    {
        switch (character)
        {
            case Warrior:
                character.OffensiveAbilities.Add(new Strike());
                character.OffensiveAbilities.Add(new Execute());
                character.DefensiveAbility = new SkinHarden();
                break;
            case Knight:
                character.OffensiveAbilities.Add(new HolyBlow());
                character.OffensiveAbilities.Add(new PurifySoul());
                character.DefensiveAbility = new RighteousWings();
                break;
            case Assassin:
                character.OffensiveAbilities.Add(new Raze());
                character.OffensiveAbilities.Add(new BleedToDeath());
                character.DefensiveAbility = new Survival();
                break;
            case Mage:
                character.OffensiveAbilities.Add(new ArcaneWrath());
                character.OffensiveAbilities.Add(new FireWall());
                character.DefensiveAbility = new Meditation();
                break;
            case Necromancer:
                character.OffensiveAbilities.Add(new ShadowRage());
                character.OffensiveAbilities.Add(new VampireTouch());
                character.DefensiveAbility = new BoneShield();
                break;
            case Druid:
                character.OffensiveAbilities.Add(new Moonfire());
                character.OffensiveAbilities.Add(new Starburst());
                character.DefensiveAbility = new OneWithTheNature();
                break;
        }
    }
}