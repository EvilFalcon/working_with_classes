using System;

namespace working_with_classes
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero('♂');
            Renderer renderer = new Renderer();

            hero.ShowInfo();
            renderer.Draw(hero);
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
        private int _positionX = 9;
        private int _positionY = 9;

        public Hero(char symbol)
        {
            _grade = "Паладин";
            _health = 100;
            _magicPoints = 40;
            _armor = 40;
            _damage = 20;
            _magicDamage = 10;
            Symbol = symbol;
        }

        public char Symbol { get; private set; }

        public int PositionX
        {
            get
            {
                return _positionX;
            }
            private set
            {
                if (IsRangeExist(PositionX))
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
            private set
            {
                if (IsRangeExist(PositionY))
                {
                    _positionY = PositionY;
                }
            }
        }

        private bool IsRangeExist(int position)
        {
            int positionMapMin = 0;
            int positionMapMax = 10;

            if (position >= positionMapMin && position <= positionMapMax)
            {
                return true;
            }

            return false;
        }

        public void ShowInfo()
        {
            int positionShowInfoX = 0;
            int positionShowInfoY = 10;

            Console.SetCursorPosition(positionShowInfoX, positionShowInfoY);
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

        public  void Draw(int positionX, int positionY, char symbol)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.WriteLine(symbol);
        }

        public void Draw(Hero hero)
        {
            Console.SetCursorPosition(hero.PositionX, hero.PositionY);
            Console.WriteLine(hero.Symbol);
        }
    }  
}
