using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Dz_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long cost = 8;
            bool isNew = true;
            string name = "Coco";
            int maxSpeed = 250;
            int year = 2001;

            Auto[] autos=new Auto [5];
            for(int i = 0; i < autos.Length; i++)
            {
                autos[i] = new Auto(maxSpeed, name, cost, isNew, year);
            }
            autos[2].Show();
            Console.ReadLine();

        }
    }
}
