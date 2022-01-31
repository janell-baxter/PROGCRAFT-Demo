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

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        //public string ConvertLowerCase(string message)
        //{
        //    return message.ToLower();
        //}

        public string ConvertLowerCase(string message) => message.ToLower();
    }
}
