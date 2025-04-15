using System;

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
        // Elimina un cliente del frente de la cola
        public void DesEncolar()
        {
            if (EsVacia())
            {
                Console.WriteLine("La cola está vacía. No hay clientes para eliminar.");
                return;
            }

            Console.WriteLine($"Cliente eliminado: {frente.info.Num_articulos} artículos, Total: {frente.info.Total_pagar}");

            ventaTotal -= frente.info.Total_pagar;
            totalClientes--;
            frente = frente.sig;

            if (frente == null)
                final = null;
        }


        public void Mostrar()
        {
            NodoCola ptr = frente;
            int contador = 1;

            Console.WriteLine("\n**************************** LISTADO DE CLIENTES ****************************");

            Console.WriteLine("\nNRO. DE CLIENTES: " + totalClientes);
            while (ptr != null)
            {
                Console.WriteLine("\nCLIENTE: " + contador + "\tNumero de Articulos: \t" + ptr.info.Num_articulos + "\n\t\tTotal a pagar: \t\t" + ptr.info.Total_pagar);
                ptr = ptr.sig;
                contador++;
            }
            Console.WriteLine("\n\t\t________________________________");
            Console.WriteLine("\n\t\tTOTAL DE INGRESOS: \t" + ventaTotal + '\n');
            Console.WriteLine("\n*****************************************************************************\n");
        }

        public void VerFrente()
        {
            if (EsVacia())
            {
                Console.WriteLine("La cola está vacía. No hay clientes para mostrar.");
                return;
            }

            Console.WriteLine("\n**************************** CLIENTE AL FRENTE ****************************");
            Console.WriteLine("\nNumero de Artículos: \t" + frente.info.Num_articulos);
            Console.WriteLine("Total a pagar: \t\t" + frente.info.Total_pagar);
            Console.WriteLine("***************************************************************************\n");
        }


    }

}
