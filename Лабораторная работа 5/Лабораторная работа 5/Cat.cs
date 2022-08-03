using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Cat
    {
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }
        private string? _name;
        public int Age { get; init; }
        public int Health
        {
            get
            {
                return _health;
            }
            private set
            {
                _health = value;
                if (_health < 0)
                {
                    _health = 0;
                }
            }
        }
        private int _health = 100;
        public string Color
        {
            get
            {
                if (Health > 0)
                {
                    return "зеленый";
                }
                return "белый";
            }
        }

        public void Feed(int foodCount)
        {
            _health += foodCount;
        }
        public void Punish(int punch)
        {
            _health -= punch;
        }
    }
}
