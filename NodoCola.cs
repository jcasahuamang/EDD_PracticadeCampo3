using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo3
{
    public class NodoCola
    {
        public Productos info { get; set; }
        public NodoCola sig { get; set; }

        public NodoCola() { }
        public NodoCola(Productos producto)
        {
            this.info = producto;
            this.sig = null;
        }
    }
}
