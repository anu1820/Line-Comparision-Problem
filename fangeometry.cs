using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_Problem
{
    public class fangeometry
    {
        

        
            public static void CalculateLength()
            {

                Console.WriteLine("Enter the value of ( x1 , y1 :)");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of  ( x2 , y2 :)");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of  ( d1 , b1 :)");
                int d1 = Convert.ToInt32(Console.ReadLine());
                int b1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the value of ( d2 , b2 :)");
                int d2 = Convert.ToInt32(Console.ReadLine());
                int b2 = Convert.ToInt32(Console.ReadLine());


                double LENGTH_OF_FIRST_LINE = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
                Console.WriteLine("The Length of 1st line= " + LENGTH_OF_FIRST_LINE);

                double LENGTH_OF_SECOND_LINE = Math.Sqrt(((d2 - d1) * (d2 - d1) + (b2 - b1) * (b2 - b1)));
                Console.WriteLine("The Length of 2nd line= " + LENGTH_OF_SECOND_LINE);

                Console.WriteLine("Length of Two Lines Are: " + LENGTH_OF_FIRST_LINE.Equals(LENGTH_OF_SECOND_LINE));


            }
        }
    }


