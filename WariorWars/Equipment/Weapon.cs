﻿using WariorWars.Enum;

namespace WariorWars.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE =5;
        private const int BAD_GUY_DAMAGE = 5;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.badGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }

    }
}