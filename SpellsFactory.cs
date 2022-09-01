using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spells
{
    public abstract class Spell
    {
        public abstract void UseSpell();
    }


    public class FireballAbility : Spell
    {
        public override void UseSpell()
        {

        }
    }

    public class FirestormAbility : Spell
    {
        public override void UseSpell()
        {
            
        }
    }

    public class BlizzardAbility : Spell
    {
        public override void UseSpell()
        {
            
        }
    }

    public class HollyAuraAbility : Spell
    {
        public override void UseSpell()
        {
            
        }
    }
    public class AbilityFactory
    {
        public Spell GetSpell(string abilityName)
        {
            switch(abilityName)
            {
                case "Fireball":
                return new FireballAbility();

                case "Firestorm":
                return new FirestormAbility();

                case "Blizzard":
                return new BlizzardAbility();

                case "HollyAura":
                return new HollyAuraAbility();

                default:
                return null;
            }
        }
    }
}

