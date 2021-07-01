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

        #region getList of ..
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
                command.CommandText = string.Format("SELECT * FROM land ORDER BY name;"); //Später hier kann User entscheiden, wie viele Fragen
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lands.Add(new Land(
                        reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Land" : reader.GetString(1),
                        reader.IsDBNull(2) ? "Capital" : reader.GetString(2),
                        reader.IsDBNull(3) ? "Continent" : reader.GetString(3))
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

        internal List<Statistic> getStatistic()
        {
            List<Statistic> statistics = new List<Statistic>();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT user.name, game.score, game.date" +
                    " from user inner join game on user.userID = game.userID" +
                    " order by game.score desc;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    statistics.Add(new Statistic(
                        reader.IsDBNull(0) ? "user" : reader.GetString(0),
                        reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                        reader.IsDBNull(2) ? "Datum" : reader.GetString(2)
                        ));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return statistics;
        }
        #endregion

        #region addNew
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

        internal void addGame(Game game)
        {
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = string.Format("INSERT INTO game VALUES(null, {0}, '{1}', {2});", game.Score, game.Date.ToString("yyyy-MM-dd HH:mm:ss"), game.UserID);
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
        #endregion
    }
}
