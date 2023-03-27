using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DyJ
    {
        public string name, horario;
        public int antiguedad, edad;
        public string[] productosDisponibles= new string[4] {"Guitarra","Guitarra 2", "Guitarra 3","Guitarra 4"};
        public double[] precioDeProductos= new double[4] {1.11,2.22,3.33,3.0};
        public static int numTrans;

        public DyJ()
        {
            this.edad=18;
            this.horario="matutino";
        }
        static DyJ()
        {
             numTrans = 1000;
        }
        public bool checkProducto(out double precioTotal,int cantidad=1, params string[] producto)
        {
           foreach(var item in producto)
            {
                for (int i = 0; i < productosDisponibles.Length; i++)
                {
                    
                    if (item.Equals(productosDisponibles[i]))
                    {
                        precioTotal = cantidad * precioDeProductos[i];

                        Console.WriteLine("Aqui? En el mundo de las guitarras? Oye no lo se");
                        return true;
                    }
                }
            }
            
            precioTotal = 0;
            Console.WriteLine("SOLO vendemos guitarras");
            return false;
        }
        public void comision(string name,double precioTotal, int antiguedad = 0)
        {
            if(antiguedad==0 && precioTotal>0)
            {
                numTrans++;
                Console.WriteLine("Tu comision es de: "+(numTrans-1000));
                Console.WriteLine(name);
                Console.WriteLine(precioTotal);
                Console.WriteLine(antiguedad);
            }
            else if(antiguedad >=5 && precioTotal > 3000 && antiguedad<30)
            {
                numTrans=numTrans+2;
                Console.WriteLine("Tu comision es de: " + (numTrans - 1000));
                Console.WriteLine(name);
                Console.WriteLine(precioTotal);
                Console.WriteLine(antiguedad);
            }
        }
        

        

    }
}
