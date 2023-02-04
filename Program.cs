using System;

namespace working_with_classes
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero("Паладин",100,40,40,20,10);
            hero.ShowInfo();
            Console.ReadKey();
            Renderer.DrawImage(hero.PositionY, hero.PositionX,hero.Symbol);
        }
    }

    class Hero
    {
        private char _symbol = '@';
        private string _grade;
        private float _health;
        private float _magicPoints;
        private int _armor;
        private int _damage;
        private int _magicDamage;
        private int _positionX=50;
        private int _positionY=0;

        public Hero(string grade,float health, float magicPoints, int armor, int damage, int magicDamage)
        {
            _grade = grade;
            _health = health;
            _magicPoints = magicPoints;
            _armor = armor;
            _damage = damage;
            _magicDamage = magicDamage;
        }

        public char Symbol
        {
            get
            {
                return _symbol;
            }
            private set 
            {
            }
        }

        public int PositionX
        {
            get
            {
                return _positionX;
            }
            set
            {
                if (PositionX > 0 && PositionX < 10)
                {
                    _positionX = PositionX;
                }
            }
        }

        public int PositionY
        {
            get
            {
                return _positionY;
            }
            set
            {
                if (PositionY < 0 && PositionY > 10) 
                {
                    _positionY = PositionY;
                }
            }
        }


        public void ShowInfo()
        {
            Console.SetCursorPosition(10, 0);
            Console.WriteLine($"Класс вашего героя :{_grade}" +
                              $"\nЗдоровье героя :{_health}" +
                              $"\nОчки магии героя :{_magicPoints}" +
                              $"\nКласс зашиты :{_armor}" +
                              $"\nСила атаки :{_damage}" +
                              $"\nМагический урон :{_magicDamage}");
        }
    }

    class Renderer
    {

        public static void DrawImage(int positionX, int positionY,char symbol)
        {
            Console.SetCursorPosition(positionY,positionX);
            Console.WriteLine(symbol);
        }
    }
}
