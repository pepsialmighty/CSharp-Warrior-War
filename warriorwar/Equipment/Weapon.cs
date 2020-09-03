using warriorwar.Enum;

namespace warriorwar.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_WEAPON = 5;
        private const int BAD_GUY_WEAPON = 5;

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
                    damage = GOOD_GUY_WEAPON;
                    break;
                case Faction.badGuy:
                    damage = BAD_GUY_WEAPON;
                    break;
                default:
                    break;
            }

        }
    }
}