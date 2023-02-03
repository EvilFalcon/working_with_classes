using System;

namespace working_with_classes
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero("Паладин",100,40,40,20,10);
            hero.ShowInfo();
        }
    }

    class Hero
    {



        private string _grade;
        private float _health;
        private float _magicPoints;
        private int _armor;
        private int _damage;
        private int _magicDamage;

        public Hero(string grade,float health, float magicPoints, int armor, int damage, int magicDamage)
        {
            _grade = grade;
            _health = health;
            _magicPoints = magicPoints;
            _armor = armor;
            _damage = damage;
            _magicDamage = magicDamage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Класс вашего героя :{_grade}" +
                              $"\nЗдоровье героя :{_health}" +
                              $"\nОчки магии героя :{_magicPoints}" +
                              $"\nКласс зашиты :{_armor}" +
                              $"\nСила атаки :{_damage}" +
                              $"\nМагический урон :{_magicDamage}");
        }
    }
}
