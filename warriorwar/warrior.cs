using System;
using System.Threading;
using warriorwar.Enum;
using warriorwar.Equipment;

namespace warriorwar
{
    class warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 50 ;
        private const int BAD_GUY_STARTING_HEALTH = 50;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public warrior(string name, Faction faction )
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;


            switch (faction)
            {
                case Faction.goodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.badGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }

            
        }


        public void Attack(warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoint;

            enemy.health -= damage;

            AttackResult(enemy, damage);

            Thread.Sleep(200);
        }

        private void AttackResult(warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Yellow);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. \n{damage} was infilicted to {enemy.name}, remaining health of {enemy.health} is {enemy.health} ");
                Console.WriteLine("--------------------------------------------------------------------------");
            }
        }
    }
}
