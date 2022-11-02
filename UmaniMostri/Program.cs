using System;

namespace UmaniMostri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eroe e = new Eroe(10);
            Vampiro v = new Vampiro(15);
            Licantropo l = new Licantropo(10, 15,false, true);

            for (int i = 0; i < 3; i++)
            {
                
                e.Combatti();
                
                Console.WriteLine(e.getforza());


            }

            for (int i = 0; i < 2; i++)
            {
                l.Azzanna();
                l.Combatti();
                Console.WriteLine(l.getforza());
            }

            for (int i = 0; i < 1; i++)
            {
                v.Azzanna();


                Console.WriteLine(v.getforza());
            }


        }

    }
}



