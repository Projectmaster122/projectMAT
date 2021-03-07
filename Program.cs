using System;

namespace PMOS
{
    class os
    {
        public static void echos(string input)
        {
            Console.WriteLine(input);
        }
    }
    class Program
    {
        static void krnl()
        {
            Console.WriteLine("Welcome to the PMOS kernel!\nPlease use our commands to control the os");
            bool isActivated = false;
            string cmd = Console.ReadLine();
            if (cmd == "echos")
            {
                string  e = Console.ReadLine();
                os.echos(e);
                krnl();
            }
        }
        static void Main(string[] args)
        {
            Program.krnl();
        }
    }
}
