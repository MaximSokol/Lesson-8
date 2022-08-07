using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Accountant
    {
        public bool AskForBonus(Cvalifications cval, int hours)
        {
            switch (hours)
            {
                case (int)Cvalifications.junior:

                    Console.Write("Enter the working hours ->\t");
                    int workingHours = int.Parse(Console.ReadLine());

                    if(workingHours >= Program.junClocks)
                        Console.WriteLine("So boy you can get your overwoking money!");
                    else
                        Console.WriteLine("Boy. Not today!");
                    break;
                    //--------------------------------------------------------------------

                case (int)Cvalifications.middle:

                    Console.Write("Enter the working hours ->\t");
                    workingHours = int.Parse(Console.ReadLine());

                    if(workingHours >= Program.midClocks)
                        Console.WriteLine("So boy you can get your overwoking money!");
                    else
                        Console.WriteLine("Boy. Not today!");
                    break;
                    //--------------------------------------------------------------------

                case (int)Cvalifications.senior:

                    Console.WriteLine("Enter the working hours ->\t");
                    workingHours = int.Parse(Console.ReadLine());

                    if (workingHours >= Program.midClocks)
                        Console.WriteLine("So boy you can get your overwoking money!");
                    else
                        Console.WriteLine("Boy. Not today!");
                    break;
                    //--------------------------------------------------------------------

                default:
                    Console.WriteLine("Unknown exception!");
                    break;
            }
            return true;
        }
    }
}
