using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFFCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Gam", 10, 15);
            Enemy enemy = new Enemy("Murloc", 5, 25);

            int heroHealth = hero.GetHealth;
            int heroDamage = hero.GetDamage;

            int enemyHealth = enemy.GetHealth;
            int enemyDamage = enemy.GetDamage;

            Random random = new Random();
            int firstStep = random.Next(1, 3);
            
            if (firstStep == 1)
            {
                Console.WriteLine("First is Hero");
                while (true)
                {
                    HeroAttack(ref heroDamage, ref enemyHealth, ref heroHealth, ref enemyDamage);
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("Enemy is deid");
                        break;
                    }
                    EnemyAttack(ref  heroDamage, ref  enemyHealth, ref  heroHealth, ref enemyDamage);
                    if (heroHealth <= 0)
                    {
                        Console.WriteLine("Hero is deid");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("First is Enemy");
                while (true)
                {
                    EnemyAttack(ref  heroDamage, ref  enemyHealth, ref  heroHealth, ref  enemyDamage);
                    if (heroHealth <= 0)
                    {
                        Console.WriteLine("Hero is deid");
                        break;
                    }
                    HeroAttack(ref heroDamage, ref enemyHealth, ref heroHealth, ref enemyDamage);
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("Enemy is deid");
                        break;
                    }

                }
            }
            
            
            
        }
        public static void EnemyAttack(ref int heroDamage,ref int enemyHealth, ref int heroHealth, ref int enemyDamage)
        {

            heroHealth -= enemyDamage;
            Console.WriteLine("Enemy is attacking - " + heroDamage);
            Console.WriteLine("HP Hero - " + enemyHealth);
                        
        }
        public static void HeroAttack(ref int heroDamage, ref int enemyHealth, ref int heroHealth, ref int enemyDamage)
        {
            enemyHealth -= heroDamage;
            Console.WriteLine("Hero is attacking - " + enemyDamage);
            Console.WriteLine("HP Enemy - " + heroHealth);

        }
    }
}
