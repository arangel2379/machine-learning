using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGAARV
{
    public abstract class constantes
    {
        
        static public int sizeCromosoma = 30;       
        static public int sizePoblacion = 50;
        
        static public int functionXSize = (int)Math.Pow(2, sizeCromosoma);
        public static Random random = new Random((int)DateTime.Now.Ticks);  

        public static double function1(double x)
        {
            return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }




    }
}
