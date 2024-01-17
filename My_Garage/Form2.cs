using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string couleurValue = couleur.Text;
            string marqueValue = marque.Text;
            string typeVValue = type.Text;  
            string immatriculationValue = Immatriculation.Text;
            string anneValue = anne.Text;

            // Créez une instance de la classe Voiture avec les valeurs récupérées
            Voiture nouvelleVoiture = new Voiture(couleurValue, marqueValue, typeVValue, immatriculationValue, anneValue);

            // Appelez la fonction AjouterVoiture
            nouvelleVoiture.AjouterVoiture();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
