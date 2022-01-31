using System;

namespace PROGCRAFT_Demo
{
    class Utility
    {
        //public static method that can be used in other classes
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
