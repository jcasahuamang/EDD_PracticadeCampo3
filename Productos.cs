using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo3
{
    public class Productos
    {
        public int Num_articulos { set; get; }
        public double Total_pagar { set; get; }

        public Productos() { }

        public Productos(int n_articulos, double t_pagar)
        {
            Num_articulos = n_articulos;
            Total_pagar = t_pagar;
        }
    }
}
