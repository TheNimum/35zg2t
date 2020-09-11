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
        public static void month(string[] args)
            {
                System.Console.WriteLine("skriv in månaden du är född i svara med 1 - 12 :");
                var monthdate = int.Parse(Console.ReadLine());
                string [] monthdayindex = {
                    "januari",
                    "februari",
                    "mars",
                    "april",
                    "maj",
                    "juni",
                    "juli",
                    "augusti",
                    "september",
                    "oktober",
                    "november",
                    "december"
                };

                int result = Array.IndexOf(monthdayindex, monthdate) +1;
                System.Console.WriteLine(result);





            int day = int.Parse(Console.ReadLine());
            string stringday = "" + day;
                if(stringday.lengt == 1){
                   stringday = "0" + day;     
                }

                string completedate =  monthly + stringday;

                int resultdata = int.Parse(completedate);

                String starsign  = "";

                if(321 >= && => 419 ) {
                    starsign = "väduren";

                }
                else if(420 >= && => 520 ) {
                    starsign = "oxen";

                }
                else if(521 >= && => 621 ) {
                    starsign = "tvillingen";

                }
                else if(622 >= && => 722 ) {
                    starsign = "kräftan";

                }
                else if(723 >= && => 822 ) {
                    starsign = "lejonet";

                }
                else if(823 >= && => 922 ) {
                    starsign = "ljungfrun";

                }
                else if(923 >= && => 1022 ) {
                    starsign = "vågen";

                }
                else if(1023 >= && => 1121 ) {
                    starsign = "skorpionen";

                }
                else if(1122 >= && => 119 ) {
                    starsign = "skytten";

                }
                else if(120 >= && => 218 ) {
                    starsign = "stenbocken";

                }
                else if(xxxx >= && => xxxx ) {
                    starsign = "vattunmannen";

                }
                else if(219 >= && => 320 ) {
                    starsign = "fiskar";

                }

                Console.WriteLine($"du är född i {month} och du är stjärntecknet {starsign}");
        
            

           

            }
            
            
            Console.ReadLine();
             
            }
            
            

        
    }
}
