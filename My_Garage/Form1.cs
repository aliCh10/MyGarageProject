using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace My_Garage
{
    public partial class Form1 : Form
    {
        private string immatriculationSelectionnee; // Variable pour stocker l'immatriculation sélectionnée

        public Form1()
        {
            InitializeComponent();
            string mysqlconn = "server=127.0.0.1;user=root;database=crud;password=";
            MySqlConnection conn = new MySqlConnection(mysqlconn);
            try
            {
                conn.Open();
                MessageBox.Show("coonection reuissite");
            }
            catch (Exception e)
            {
                MessageBox.Show("connection echoueé");
            }
            finally { conn.Close(); }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherToutesImmatriculations();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void AfficherToutesImmatriculations()
        {
            // Appel de la fonction pour obtenir toutes les immatriculations
            List<string> immatriculations = new Voiture().GetAllImmatriculations();

            // Affichage des immatriculations dans le label
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Immatriculations :");
            foreach (string immatriculation in immatriculations)
            {
                sb.AppendLine(immatriculation);
            }
            affichageV.Text = sb.ToString();
        }



       

    }
}
