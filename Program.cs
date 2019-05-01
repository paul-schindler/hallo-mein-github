using System;

namespace hallo_mein_github
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
              Console.WriteLine("Hello World! "+ args[0]);
            
            else
              Console.WriteLine("Hello World ohne Argumente!");
        }
    }
}
