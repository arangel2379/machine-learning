using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;

namespace AGAARV
{
    public partial class Form1 : Form
    {
        private Poblacion population;
        private int cont = 0;

        private PointPairList populaPoblacion = new PointPairList();
        private PointPairList mediaPoblacion = new PointPairList();


        public Form1()
        {
            InitializeComponent();

        }

        private void _btnrun_Click(object sender, EventArgs e)
        {
            //population = new Poblacion();

            //List<string> pop = new List<string>();

            

            //for (int j = 0; j < constantes.sizePoblacion; j++)
            //{
            //    populacaoGrafico.Add(population.obtenerPoblacion()[j].obtenerEntero(), population.obtenerPoblacion()[j].obtenerFitness());

            //}

            
        }

        protected void poblacion()
        {
            population = new Poblacion();           


            for (int j = 0; j < constantes.sizePoblacion; j++)
            {
                populaPoblacion.Add(population.obtenerPoblacion()[j].obtenerEntero(), population.obtenerPoblacion()[j].obtenerFitness());
            }

        }

        private void _btnAG_Click(object sender, EventArgs e)
        {

            /* Inicia el proceso de generacion de la poblacion */
            poblacion();

            double _PM = Convert.ToDouble(_txtPM.Text);
            double _PC = Convert.ToDouble(_txtPC.Text);
            int iterevol = Convert.ToInt32(_txtEvol.Text);

            Console.Write(_PM.ToString() + "\n");
            Console.Write(_PC.ToString() + "\n");
            Console.Write(iterevol.ToString() + "\n");


            algortimoGenetico AG = new algortimoGenetico(_PC, _PM);


            //Establecemos las propiedades del ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Añadimos las columnas al ListView
            listView1.Columns.Add("Numero", 500);
            listView1.Columns.Add("Fitness", 70);
          

            //Añadimos los elementos (filas) al ListView
            string[] elementosFila = new string[2];
            ListViewItem elementoListView;


            for (int i = 0; i < iterevol; i++)
            {
                population = AG.exeAG(population);  
                populaPoblacion = new PointPairList();

                for (int j = 0; j < constantes.sizePoblacion; j++)
                {
                    populaPoblacion.Add(population.obtenerPoblacion()[j].obtenerEntero(), population.obtenerPoblacion()[j].obtenerFitness());                    

                }
            }

            population.ordenarPoblacion();

            string badcromosomas = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                badcromosomas += population.obtenerPoblacion()[i].mostrarCromosomas() + "\n";
            }

            string bestcromosomas = string.Empty;
            for (int j = constantes.sizePoblacion -1; j > (constantes.sizePoblacion -1) -10; j--)
            {
                bestcromosomas += population.obtenerPoblacion()[j].mostrarCromosomas() + "\n";
            }

            _txtBestCrom.Text = bestcromosomas;
            _txtWorstCrom.Text = badcromosomas;

        }
    }


}
