using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGAARV
{
    public class Cromosomas
    {
       
        private BitArray vCromosomas;
        private double fitness;
        private double fitnesPorcentaje;
        private double[] ruleta = { 0, 0 };                             


        public Cromosomas()
        {
            this.vCromosomas = new BitArray(constantes.sizeCromosoma);

            
            for (int i = 0; i < vCromosomas.Length; i++)
            {
                vCromosomas[i] = (constantes.random.NextDouble() >= 0.5f) ? true : false;
            }

        }


        public void mutarBit(int _posicion)
        {
            if (_posicion < vCromosomas.Length)
            {
                vCromosomas.Set(_posicion, vCromosomas[_posicion] == false ? true : false);

            }
        }

        public BitArray obtenerCromosoma()
        {
            return this.vCromosomas;
        }

        public string mostrarCromosomas()
        {
            string result = string.Empty;
            result += "Bits: ";

            for (int i = vCromosomas.Length - 1 ; i >= 0 ; i--)
            {
                result = result + (vCromosomas[i] == false ? "0" : "1");
            }

            result += "  Numero:  " + obtenerEntero() + "  Fitness:   " + obtenerFitness() + "  Porcentaje Fitness: " + obtnerPorcFitness();

            return result;

        }


        public void rangoRuleta(double _inicio, double _final)
        {
            ruleta[0] = _inicio;
            ruleta[1] = _final;
        }

        public void generararCromo(int _posicion, bool _generar)
        {
            this.vCromosomas[_posicion] = _generar;
        }

        public bool obtenerCromo(int _posicion)
        {
            return vCromosomas[_posicion];
        }

        public void genFitness(double _fitness)
        {
            this.fitness = _fitness;
        }

        public double obtenerFitness()
        {
            return this.fitness;
        }

        public void porcentajeFitness( double _porcFitness)
        {
            this.fitnesPorcentaje = _porcFitness;
        }

        public double obtnerPorcFitness()
        {
            return this.fitnesPorcentaje;
        }

        public double[] obtenerRangoRuleta()
        {
            return this.ruleta;
        }

        public int obtenerEntero()
        {
            if (vCromosomas.Length > 32)
            {
                throw new ArgumentException(" El valor del Cromosoma debe de ser mayor a 32 bits");
            }

            int[] array = new int[1];
            vCromosomas.CopyTo(array, 0);
            return array[0];
        }
    }
}
