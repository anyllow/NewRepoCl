using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFFCC
{
    internal class Enemy
    {
        protected string _name;
        protected int _damage { get; set; }
        protected int _health { get; set; }

        public Enemy(string name, int damage, int health)
        {
            _name = name;
            _damage = damage;
            _health = health;
        }
        public int GetHealth { get { return _health; } }
        public int GetDamage { get { return _damage; } }

        public void SetHealth(int health)
        {
            _health = health;
        }
        public void SetDamage(int damage)
        {
            _damage = damage;
        }
    }
}
