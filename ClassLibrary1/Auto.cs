using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auto
    {
        private int _maxSpeed;
        private string _name;
        private long _cost;//цена
        private bool _isNew;
        private int _yearOfCreate;//год создания
        static int _countOfCar;
        
        public Auto()
        {
            _maxSpeed = 0;
            _name = "NoName";
            _cost = 0;
            _isNew = true;
            _yearOfCreate = 0;
            _countOfCar++;
        }
        static Auto()
        {
            _countOfCar = 0;
        }
        public void Show();
        public bool IsBuy(int money);//хватает ли на покупку
        public bool IsNew();//Новая ли машина 
        public void SetMaxSpeed(int maxspeed)
        {
            _maxSpeed = maxspeed;
        }
        public int GetMaxSpeed()
        {
            return (_maxSpeed);
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return (_name);
        }
        public void SetCost(long cost)
        {
            _cost = cost;
        }
        public long GetCost()
        {
            return (_cost);
        }
        public void SetYear(int year)
        {
            _yearOfCreate = year;
        }
        public int GetYear()
        {
            return (_yearOfCreate);
        }


    }
}
