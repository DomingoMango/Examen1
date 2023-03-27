using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioTotal=0;
            DyJ Josh = new DyJ();
            Josh.checkProducto(out precioTotal, 2, "Guitarra 2");
            Josh.comision("Josh", precioTotal);
        }
    }
}
