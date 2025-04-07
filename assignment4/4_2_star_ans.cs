using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            void typeC(int row)
            {
                if( row == 1)
                {
                    Console.Write(new string(' ',size));
                }
                else if( row == 2 || row == size)
                {
                    Console.Write("  "+new string('*',size-3)+" ");
                }
                else
                {
                    Console.Write(" *"+ new string(' ', size-2));
                }
            }
            void typeSharp(int row)
            {
                if( row == (int)(size/3) || row == (int)(size*2/3))
                {
                    Console.WriteLine(new string('*', size));
                }
                else
                {
                    Console.WriteLine(new string(' ', (int)(size/3)-1)+'*'+new string(' ', (int)(size/3)-1)+'*');
                }
            }

            for(int i=1; i <= size; i++)
            {
                typeC(i);
                typeSharp(i);
            }

            
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/