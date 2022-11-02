using System;

namespace UmaniMostri
{
    public class Licantropo
    {

        public int forzaUmano;
        public int forzaMostro;
        private bool isuomo;
        public bool luna;

        public Licantropo(int forzaUmano,int forzaMostro,bool isuomo,bool luna)
        {
            this.forzaUmano = forzaUmano;
            this.forzaMostro = forzaMostro;
            
            this.isuomo = isuomo;
            this.luna = luna;
            
        }

        public string getforza()
        {
            Console.WriteLine("-------");
            Console.WriteLine("\nLicantropo: ");
            
            return ("\nForza rimanente come Umano: " + forzaUmano+ " \nForza rimanente come Mostro: "+forzaMostro);
            
        }


        public void Azzanna()
        {
            if (isuomo == false)
            {
                forzaMostro = forzaMostro - 2;
            }
            if (isuomo == true && luna == true)
            {

                forzaMostro = 0; forzaUmano = 0;
            }
        }

        public void Combatti()
        {
            if(isuomo == true)
            {
                forzaUmano = forzaUmano - 3;
            }
            if (isuomo == true && luna == true)
            {

                forzaMostro = 0; forzaUmano = 0;
            }
        }

    }

}



