using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace prwtosAri8mos
{
    class Program
    {
        static bool CheckPrime(int n)
        {   
            /* thn askhsh thn elusa metrwntas ta upoloipa ths diaireshs pou kanoun 0,
             * proseksa oti gia na einai PRWTOS enas ari8mos xreiazonte 2 upoloipa diaireshs
             * pou kanoun 0. an eixe panw apo 2 upoloipa dn 8a htan PRWTOS ari8mos. h parakatw lush 
             * dinei to anamenomeno apotelesma gia ari8mous pou dinei o xrhsths n=2,3,4,5,...
            */
            int metrhthsUpoloipou = 0; // metraei posa upoloipa ths diaireshs dinoun 0
            int i = 0; /* opou i einai enas ari8mos pou 8a diairei ton ari8mo N tou xrhsth 
                        * kai 8a auksanetai kata 1 se ka8e epanalhpsh mexri o i na ftasei thn timh
                        * N pou exei dwsei o xrhsths
                        */
            int upoloipo = 0; // metablhth pou apo8hkeuw to upoloipo ths diaireshs 
            while (i <= n)
            {
                i++;
                upoloipo = n % i;
                if (upoloipo == 0)
                {
                    metrhthsUpoloipou++;
                }

            }
            if (metrhthsUpoloipou == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dwste enan 8etiko ari8mo");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Dokimaste na ksanadwsete enan 8etiko ari8mo");
                int b = Convert.ToInt32(Console.ReadLine());
                a=b;
            }

            if ((CheckPrime(a) == true) || (a==1)) // exw 8esh a==1 sthn periptwsh pou o xrhsths dwsei 1
            {
                Console.WriteLine("O ari8mos {0} einai prwtos", a);    
            }
            else
            {
                Console.WriteLine("O ari8mos {0} den einai prwtos", a);
            }
        }
    }
}
