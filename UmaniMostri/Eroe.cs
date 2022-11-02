using System;

namespace UmaniMostri
{
    public class Eroe
    {

        public int forza;
        
        public Eroe(int forza)
        {
            this.forza = forza;
            
        }

        public void Combatti()
        {
            forza = forza - 3;
        }

        public string getforza()
        {
            Console.WriteLine("----------");
            Console.WriteLine("\nEore: ");
            
            return ("\nForza rimanente come Eroe: " + forza);
           

        }


    }


}



