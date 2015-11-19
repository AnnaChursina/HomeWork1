using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private int _age;
        private int _health = 3;
        public string CurrentColor
        {
            get { return _health >= 5 ? CatColor.HealthyColor : CatColor.SickColor; }
        }

        public CatColor CatColor { get; } = new CatColor(); 
       public Cat(int age) // конструктор
        {
            this._age = age;
        }
        public int Age
        {
            get { return _age; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("You can't change your cat's name!");
                }
            }
        }
        public int Feed()
        {
            _health++;
            return _health;
        }
        public int Punish()
        {
            _health--;
            return _health;
        }
    }
}

