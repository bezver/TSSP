using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

using System.Windows;

namespace Kandidaten
{
    public class MyDatabase
    {
        public MySqlConnection connection;

        public MyDatabase(string connStr)
        {
            connection = new MySqlConnection(connStr);
        }

        public List<Entrant> XXSelection(double averageMark)
        {
            List<Entrant> entrants = new List<Entrant>();
            MySqlCommand command = new MySqlCommand("Select * From entrants Where averageMark >= @AverageMark Order By averageMark Desc", connection);
            command.Parameters.Add("@AverageMark", MySqlDbType.Double).Value = averageMark;
            command.Connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Entrant tmp = new Entrant((string)reader["firstName"], (string)reader["secondName"], (double)reader["averageMark"], (uint)reader["school"]);
                entrants.Add(tmp);
            }
            command.Connection.Close();
            return entrants;
        }

        public List<Entrant> XX_ZZSelection(double averageMark, uint school)
        {
            List<Entrant> entrants = new List<Entrant>();
            MySqlCommand command = new MySqlCommand("Select * From entrants Where averageMark >= @AverageMark && school = @School Order By averageMark Desc", connection);
            command.Parameters.Add("@AverageMark", MySqlDbType.Double).Value = averageMark;
            command.Parameters.Add("@School", MySqlDbType.UInt32).Value = school;
            command.Connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Entrant tmp = new Entrant((string)reader["firstName"], (string)reader["secondName"], (double)reader["averageMark"], (uint)reader["school"]);
                entrants.Add(tmp);
            }
            command.Connection.Close();
            return entrants;
        }

        public void AddEntrant(Entrant entrant)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO entrants (id, firstName, secondName, averageMark, school) VALUES (NULL, @uS, @uN, @uY, @uP)", connection);
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = entrant.firstName;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = entrant.secondName;
            command.Parameters.Add("@uY", MySqlDbType.Double).Value  = entrant.averageMark;
            command.Parameters.Add("@uP", MySqlDbType.UInt32).Value  = entrant.school;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteEntrant(Entrant entrant)
        {
            connection.Open();
            
            MySqlCommand command = new MySqlCommand("DELETE FROM entrants WHERE firstName = @uS AND secondName = @uN AND averageMark = @uY AND school = @uP", connection);
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = entrant.firstName;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = entrant.secondName;
            command.Parameters.Add("@uY", MySqlDbType.Double).Value = entrant.averageMark;
            command.Parameters.Add("@uP", MySqlDbType.UInt32).Value = entrant.school;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void readDB()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM entrants", connection);
            command.Connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Entrant tmp = new Entrant((string)reader["firstName"], (string)reader["secondName"], (double)reader["averageMark"], (uint)reader["school"]);
                MessageBox.Show(tmp.ToString());
            }
            command.Connection.Close();
        }

    }
}
