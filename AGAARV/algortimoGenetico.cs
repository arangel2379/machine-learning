using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGAARV
{
    public class algortimoGenetico
    {
       
        private double PC;      
        private double PM;
        static int PAI = 0;
        static int MAE = 1;


        public algortimoGenetico(double _pc, double _pm)
        {
            this.PC = _pc;
            this.PM = _pm;
        }

        public Poblacion exeAG(Poblacion _pob)
        {
            Poblacion nuevaPoblacion = new Poblacion();
            List<Cromosomas> popBuffer = new List<Cromosomas>();

            for (int i = 0; i < (constantes.sizePoblacion / 2); i++)
            {
                /* seleccionamos el cromosoma */

                Cromosomas pai = Ruleta(_pob);
                Cromosomas mae = Ruleta(_pob);

                /* se realiza el cruzamiento*/

                Cromosomas[] cross = Crossover(pai, mae);

                /*Mutacion*/

                Cromosomas crossA = Mutacion(cross[0]);
                Cromosomas crossB = Mutacion(cross[1]);

                popBuffer.Add(crossA);
                popBuffer.Add(crossB);
            }

            /* Eliminar cromosomas antiguos e 
                Insertar los nuevos  
            */

            for (int x = 0; x < constantes.sizePoblacion; x++)
            {
                nuevaPoblacion.cromosomas(x, popBuffer[x]);
            }

            popBuffer = null;

            nuevaPoblacion.actualizarValores();

            return nuevaPoblacion;
        }

        public Cromosomas Ruleta(Poblacion _pop)
        {
            double numSorteado = (constantes.random.NextDouble() * 100);
            Cromosomas cm ;

            foreach (Cromosomas crom in _pop.obtenerPoblacion())
            {
                if(numSorteado >= crom.obtenerRangoRuleta()[0] && numSorteado <= crom.obtenerRangoRuleta()[1])
                {
                    return crom;

                }
            }          

            return null;
        }

        public Cromosomas Mutacion(Cromosomas _crom)
        {
            if(constantes.random.NextDouble() <= PM)
            {
                int posicion = constantes.random.Next(0, constantes.sizeCromosoma);
                _crom.mutarBit(posicion);
                return _crom;
            }

            return _crom;

        }

        public Cromosomas[] Crossover( Cromosomas _pai, Cromosomas _mae)
        {
            Cromosomas[] newCrom = new Cromosomas[2];
            int puntocorte = constantes.random.Next(0, constantes.sizeCromosoma - 1);

            Cromosomas paiBuffer = new Cromosomas();
            Cromosomas maeBuffer = new Cromosomas();

            newCrom[PAI] = new Cromosomas();
            newCrom[MAE] = new Cromosomas();

            for (int i = 0; i < constantes.sizeCromosoma; i++)
            {
                paiBuffer.generararCromo(i, _pai.obtenerCromo(i));
                maeBuffer.generararCromo(i, _mae.obtenerCromo(i));

                newCrom[PAI].generararCromo(i, _pai.obtenerCromo(i));
                newCrom[MAE].generararCromo(i, _mae.obtenerCromo(i));
            }

            if(constantes.random.NextDouble() < PC)
            {
                for (int i = puntocorte; i < constantes.sizeCromosoma; i++)
                {
                    newCrom[PAI].generararCromo(i, _pai.obtenerCromo(i));
                    newCrom[MAE].generararCromo(i, _mae.obtenerCromo(i));
                }

            }

            return newCrom;
        }
    }
}
