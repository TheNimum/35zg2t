using System;

namespace _35zg2t
{
    class Program
    {
        static void Main(string[] args)
        {
            month();
            Console.ReadKey ();
        }
        public static void month()
            {
            string [] month =  {"januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december"};
            System.Console.WriteLine("vilken månad är du född i svara med 1-12; ");
            int dat = int.Parse(Console.ReadLine());
            var i =  month[dat -1]; 
            Console.WriteLine($"Du är född i: {i} "); 
            
            Console.ReadLine();
             
            }
            
            

        
    }
}
