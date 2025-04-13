using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo3
{
    public class Cola
    {

        private NodoCola frente, final, nuevo;
        private int totalClientes = 0;  //Para guardar el total de clientes
        private double ventaTotal = 0.0; //Para guardar el total de venta
        public Cola()
        {
            frente = null;
            final = null;
        }
        public bool EsVacia()
        {
            return frente == null;
        }
        public void EnColar(Productos cliente)
        {
            nuevo = new NodoCola(cliente);
            if (EsVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.sig = nuevo;
                final = nuevo;
            }
            totalClientes++;
            ventaTotal += cliente.Total_pagar;
        }
        public void Mostrar()
        {
            NodoCola ptr = frente;
            int contador = 1;

            Console.WriteLine("\n**************************** LISTADO DE CLIENTES ****************************");

            Console.WriteLine("\nNRO. DE CLIENTES: "+ totalClientes);
            while (ptr != null)
            {
                Console.WriteLine("\nCLIENTE: "+ contador+ "\tNumero de Articulos: \t" + ptr.info.Num_articulos + "\n\t\tTotal a pagar: \t\t" + ptr.info.Total_pagar);
                ptr = ptr.sig;
                contador++;
            }
            Console.WriteLine("\n\t\t________________________________");
            Console.WriteLine("\n\t\tTOTAL DE INGRESOS: \t"+ ventaTotal+'\n');
            Console.WriteLine("\n*****************************************************************************\n");
        }

    }
}
