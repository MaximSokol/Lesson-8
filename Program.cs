using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{

    //public enum EnumColors
    //{
    //    Blue,
    //    Red,
    //    Yellow
    //}

    public enum Cvalifications
    {
        junior,
        middle,
        senior
    }

    class Program
    {
        //public static DateTime now = DateTime.Now;             // These fields are special for "ADDITIONAL TASK"
        //public static DateTime birthday;
        //public static TimeSpan wait;

        public const int junClocks = 120;
        public const int midClocks = 240;
        public const int senClocks = 480;

        static void Main(string[] args)
        {
            // Additional task


            //Console.WriteLine("Enter your birthday ->");
            //birthday = Convert.ToDateTime(Console.ReadLine());

            //DateTime thisTime = new DateTime(now.Year, birthday.Month, birthday.Day);

            //wait = now - thisTime;

            //Console.WriteLine($"The days left\t{wait.Days}\n");

            // Task 2

            //while (true)
            //{
            //    Console.Write("Enter the number of a color ->\t");
            //    int number = int.Parse(Console.ReadLine());

            //    SomeStaticClass.PrintColorString("I'm a perfect programmer!", number);
            //}


            // Task 3


            int num = int.Parse(Console.ReadLine());

            Accountant ac = new Accountant();
            ac.AskForBonus(Cvalifications.junior, num);
        }
    }
}
