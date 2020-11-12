using System;

namespace Strategy
{
    class Program
    {
        /*
         * Игрок принимает урон и имеет разную броню которая по разному его защищает
         */
        static void Main(string[] args)
        {
            WarriorArmor physicalArmor = new WarriorArmor();
            Player player = new Player(100, physicalArmor);
            player.ApplyDamage(4, DamageType.Magic);

            MageArmour mageArmor = new MageArmour();
            Player player2 = new Player(100, mageArmor);
            player2.ApplyDamage(4, DamageType.Magic);
        }
    }
    enum DamageType
    {
        Physic,
        Magic
    }

    class Player
    {
        private int _health;
        private IArmor _armor;

        public Player(int health, IArmor armor)
        {
            _health = health;
            _armor = armor;
        }

        public virtual void ApplyDamage(int damage, DamageType damageType)
        {
            if (damage < 0) throw new ArgumentOutOfRangeException();

            _health -= _armor.Process(damage, damageType);
            Console.WriteLine(_health);

            if (_health <= 0)
            {
                Console.WriteLine("I'm death");
            }
        }

        public int Process(int damage)
        {
            return damage;
        }
    }

    interface IArmor
    {
        int Process(int damage, DamageType damageType);
    }

    class WarriorArmor : IArmor
    {
        public int Process(int damage, DamageType damageType)
        {
            if (damageType == DamageType.Physic)
                return damage / 2;
            else
                return damage;
        }
    }

    class MageArmour : IArmor
    {
        public int Process(int damage, DamageType damageType)
        {
            if (damageType == DamageType.Magic)
                return damage / 2;
            else
                return damage;
        }
    }
}
