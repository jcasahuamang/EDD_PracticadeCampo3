using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Cola miCola = new Cola();

            /******   Insertando compras dinamicamente *************************/
            int numClientesMax = rand.Next(1, 6);
            int i = 1;
            while (i <= numClientesMax)
            {
                miCola.EnColar(new Productos(rand.Next(1, 10), 
                                               Math.Round( 5 + ( rand.NextDouble() * 100),2)                                               
                                               ) );
                i++;
            }

            /*********  Imprimiendo compra ***********************/
            miCola.Mostrar();
            Console.ReadLine();

        }
    }
}
