using System;
using System.Data;

namespace UmaniMostri
{
    public class Vampiro
    {

        public int forza;
        
        public Vampiro (int forza)
        {
            this.forza = forza;
            
        }



        public void Azzanna()
        {
            forza = forza - 2;
        }

        public string getforza()
        {
            Console.WriteLine("----------");
            Console.WriteLine("VAMPIRO: ");
            return ("\nForza rimanente come Vampiro: " + forza);
        }



    }
    



}



