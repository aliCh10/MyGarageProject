using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

internal class User
{
    public String Email { get; private set; }
    public String Password { get; private set; }

    public User(String email, String password)
    {
        this.Email = email;
        this.Password = password;
    }

    public bool Login(string enteredEmail, string enteredPassword)
    {
        MySqlConnection conn = null;

        try
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=crud;password=";
            conn = new MySqlConnection(mysqlconn);
            conn.Open();

            string query = "SELECT Email, Password FROM User WHERE Email = @enteredEmail";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@enteredEmail", enteredEmail);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Vérifiez si le mot de passe correspond
                    return reader.GetString("Password") == enteredPassword;
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
        finally
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        return false; // Échec de la connexion
    }

    internal bool Login()
    {
        throw new NotImplementedException();
    }
}
