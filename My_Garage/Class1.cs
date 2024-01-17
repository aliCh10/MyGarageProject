using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;

internal class Voiture
{
    public String Immatriculation { get; private set; }
    public String Marque { get; private set; }
    public String Couleur { get; private set; }
    public String TypeV { get; private set; }
    public String Anne { get; private set; }
    public Voiture()
    {
    }
    public Voiture(String couleur, String marque, String typeV, String immatriculation, String anne)
    {
        this.Couleur = couleur;
        this.Marque = marque;
        this.TypeV = typeV;
        this.Immatriculation = immatriculation;
        this.Anne = anne;
    }

    public void AjouterVoiture()
    {
        MySqlConnection conn = null;

        try
        {
            // Remplacez les informations de connexion par les vôtres
            string mysqlconn = "server=127.0.0.1;user=root;database=crud;password=";
            conn = new MySqlConnection(mysqlconn);

            conn.Open();

            // Utilisez un paramètre pour éviter les attaques par injection SQL
            string query = "INSERT INTO Voiture (couleur, marque, typeV, Immatriculation, anne) VALUES (@couleur, @marque, @typeV, @immatriculation, @anne)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@couleur", Couleur);
            cmd.Parameters.AddWithValue("@marque", Marque);
            cmd.Parameters.AddWithValue("@typeV", TypeV);
            cmd.Parameters.AddWithValue("@immatriculation", Immatriculation);
            cmd.Parameters.AddWithValue("@anne", Anne);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Voiture ajoutée avec succès!");
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Erreur MySQL: {ex.Message}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur: {ex.Message}");
        }
        finally
        {
            // Fermer la connexion
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
    public List<string> GetAllImmatriculations()
    {
        List<string> immatriculations = new List<string>();

        try
        {
            // Remplacez les informations de connexion par les vôtres
            string mysqlconn = "server=127.0.0.1;user=root;database=crud;password=";
            MySqlConnection conn = new MySqlConnection(mysqlconn);

            conn.Open();

            // Utilisez une requête SELECT pour récupérer toutes les immatriculations des voitures
            string query = "SELECT Immatriculation FROM Voiture";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Ajoutez chaque immatriculation à la liste
                    immatriculations.Add(reader.GetString("Immatriculation"));
                }
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Erreur MySQL: {ex.Message}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur: {ex.Message}");
        }

        return immatriculations;
    }

    public bool SupprimerVoitureParImmatriculation(string immatriculation)
    {
        MySqlConnection conn = null;

        try
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=crud;password=";
            conn = new MySqlConnection(mysqlconn);
            conn.Open();

            // Utilisez un paramètre pour éviter les attaques par injection SQL
            string query = "DELETE FROM Voiture WHERE Immatriculation = @immatriculation";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@immatriculation", immatriculation);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected > 0; // Si des lignes ont été affectées, la suppression a réussi
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Erreur MySQL: {ex.Message}");
            return false; // Échec de la suppression
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur: {ex.Message}");
            return false; // Échec de la suppression
        }
        finally
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

    
