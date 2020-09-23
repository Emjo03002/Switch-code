using System;

namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vilket program vill du köra?"); //Man väljer vilket program man vill köra
            Console.WriteLine("1.Miniräknare med två heltal");
            Console.WriteLine("2.Rektangels Omkrets och Area");
            Console.WriteLine("3.Beräkna ditt elpris (kWh pris 3kr)");
            Console.WriteLine("4.Rabatt på en vara");
            Console.Write("Skriv programets siffra:");
            int Pgr= int.Parse(Console.ReadLine());

            switch(Pgr) 
            {
                case 1:
            Console.WriteLine("Skriv två heltal"); //Alla fyra räknesäten på två hel tal
            int tal1= int.Parse(Console.ReadLine());
            int tal2= int.Parse(Console.ReadLine());
            Console.Write("Summan=");
            Console.WriteLine(tal1 + tal2);
            Console.Write("Produkten=");
            Console.WriteLine(tal1 * tal2);
            Console.Write("Differens=");
            Console.WriteLine(tal1 - tal2);
            Console.Write("Kvoten=");
            Console.WriteLine(tal1 / tal2);
            break;

                case 2:
            Console.WriteLine("Skriv rektanglens mått i meter!"); //Rektanglens Omkrets och Area
            Console.Write("Längd:");
            int tal3= int.Parse(Console.ReadLine());
            Console.Write("Bredd:");
            int tal4= int.Parse(Console.ReadLine());
            Console.Write("Omkrets: ");
            Console.WriteLine(tal3 + tal3 + tal4 + tal4);
            Console.Write("Area: ");
            Console.WriteLine(tal3 * tal4);
            break;

                case 3:
            Console.Write("Första mättalet:"); //Elkostnaden för ett kavtal
            int tal5= int.Parse(Console.ReadLine());
            Console.Write("Andra mättalet:");
            int tal6= int.Parse(Console.ReadLine());
            Console.WriteLine("Ditt Elpris är:");
            Console.Write(3*(tal6-tal5)+500);
            Console.Write("Kr");
            break;

                case 4:
            Console.WriteLine("Skriv Priset på din vara i kronor"); //Beräknar rabatt
            Console.WriteLine("Om din vara kostar 500kr så är det 10% rabatt annas är det 2%");
            Double tal7= Double.Parse(Console.ReadLine());
                                   
                if(tal7>500)
                    Console.WriteLine("10% rabatt: "+ tal7*0.1 + "kr");
                    
                else
                    Console.WriteLine("2% rabatt: "+ tal7*0.02 + "kr");
                    break;
                
            
            
            }            
        }
    }
}
