using System;
using System.Linq; // inte säker på om jag ska använda den men om i sådana fall hur ska jag göra det. 
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
            string [] month =  {"januari", "februari", "mars", "april", "maj", "juni", "juli",
             "augusti", "september", "oktober", "november", "december"};
            
            System.Console.WriteLine("vilken månad är du född i svara med 1-12; ");
            int dat = int.Parse(Console.ReadLine());
            var x =  month[dat -1]; 
            
            Console.WriteLine($"Du är född i: {x} "); 
            System.Console.WriteLine("vilkden dag fyller du år i ? : ");
            int dat1 = int.Parse(Console.ReadLine());

            string [] tec = {"stenbock", "vattunman" ,"Fiskarna", "väduren", "oxen", "tvillingen", "kräftan", "lejonet",
            "ljungfrun", " vågen", "skorpionen", "skytten" 
            };
            int result = x && tec ;

            for(int i = 0; i< dat; ++i)
            

            }
            
            
            Console.ReadLine();
             
            }
            
            

        
    }
}
