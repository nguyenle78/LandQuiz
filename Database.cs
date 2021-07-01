using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NguyenLe_QuizProject
{
    public class Database
    {
        private MySqlConnection connection;

        public Database()
        {
            string server = "SERVER = localhost; DATABASE = landquiz; UID = csharp; PASSWORD = 'nguyen';";
            connection = new MySqlConnection(server);

        }


        internal List<User> getUser()
        {
            List<User> users = new List<User>();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM user;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User(
                        reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                        reader.IsDBNull(1) ? "name" : reader.GetString(1)
                        ));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return users;
        }

        internal List<Land> getListLand()
        {
            List<Land> lands = new List<Land>();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = string.Format("SELECT * FROM land ORDER BY RAND();"); //Später hier kann User entscheiden, wie viele Fragen
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lands.Add(new Land(
                        reader.IsDBNull(0) ? -1: reader.GetInt32(0),
                        reader.IsDBNull(1)? "Land": reader.GetString(1),
                        reader.IsDBNull(2)? "Capital": reader.GetString(2),
                        reader.IsDBNull(3)? "Continent": reader.GetString(3))
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return lands;
        }

        internal void addNewUser(User user)
        {
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = string.Format("INSERT INTO user VALUES(null, '{0}');", user.Name);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
