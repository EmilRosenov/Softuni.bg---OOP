﻿using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        public FirePotion() 
            : base(5)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.Health -= 20;
           
            base.AffectCharacter(character);
        }
    }
}