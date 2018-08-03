using WariorWars.Enum;

namespace WariorWars.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR_POINTS = 5;
        private const int BAD_GUY_ARMOR_POINTS = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    armorPoints = GOOD_GUY_ARMOR_POINTS;
                    break;
                case Faction.badGuy:
                    armorPoints = BAD_GUY_ARMOR_POINTS;
                    break;
                default:
                    break;
            }

        }

    }
}