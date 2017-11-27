using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   
    public partial class Auto
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
        public Auto(int maxspeed,string name,long cost,bool isNew,int yearOFCreate)
        {
            _maxSpeed = maxspeed;
            _name = name;
            _cost = cost;
            _isNew = isNew;
            _yearOfCreate = yearOFCreate;
            _countOfCar++;
        }
        public Auto( string name, long cost, bool isNew)
        {
            _maxSpeed = 0;
            _name = name;
            _cost = cost;
            _isNew = isNew;
            _yearOfCreate = 0;
            _countOfCar++;
        }
        public void Show()
        {
            Console.WriteLine("Максимальная скорость - {0}", _maxSpeed);
            Console.WriteLine("Имя - {0}", _name);
            Console.WriteLine("Цена - {0}", _cost);
            Console.WriteLine("Год создания - {0}", _yearOfCreate);
        }
        public bool IsBuy(int money) {//хватает ли на покупку
            if (money >= _cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNew() {
            return _isNew;
        }//Новая ли машина 
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
