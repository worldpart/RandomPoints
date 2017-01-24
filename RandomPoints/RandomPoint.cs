using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace RandomPoints
{
    class RandomPoint
    {

        // Random number
        private static readonly Random r = new Random();
        /* Lock to ensure normal distribution 
         * Use won't matter due to lack of multithreading in this program
         * Included for extensibility
         */
        private static Object randLock = new object();

        // Implementation of Rand() given in the problem
        private static float Rand()
        {
            lock(randLock){
                return (float)r.NextDouble();
            }
        }

        // *** Required Method Implementation
        private static PointF Get_Random_Point_Inside_The_Circle(float Cx, float Cy, float R)
        {
            var angle = Rand() * Math.PI * 2; 

            return new PointF((float)Math.Cos(angle) * R, (float)Math.Sin(angle) * R);
        }

        static void Main(string[] args)
        {
            // Input data
            float Cx, Cy, R;
            Cx = 10;
            Cy = 5;
            R = 1;
            // Optional loop to test the method
            //for (int i = 0; i < 10; i++)
            //{
                Console.WriteLine(Get_Random_Point_Inside_The_Circle(Cx, Cy, R));
            //}

        }
    }
}
