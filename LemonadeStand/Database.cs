using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace LemonadeStand
{
    class Database
    {
        //http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/

        SQLiteConnection sqliteConnection;
        SQLiteCommand sqliteCommand;
        SQLiteDataReader sqliteRead;
        string sql;

        public void DatabaseConnect(string connectionString)
        {
            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();
        }

        public void DatabaseInsertScore(string name, int score)
        {
            sql = "insert into Score (Name, Score) values('" + name + "', " + score + ");";
            sqliteCommand = new SQLiteCommand(sql, sqliteConnection);
        }

        public void DatabaseShowScore()
        {
            sql = "SELECT Name, Score FROM Score ORDER BY Score;";
            sqliteCommand = new SQLiteCommand(sql, sqliteConnection);
            sqliteRead = sqliteCommand.ExecuteReader();
            while (sqliteRead.Read())
            {
                Console.WriteLine("Name: " + sqliteRead["NAME"] + " " + "Score: " + sqliteRead["SCORE"]);
            }
        }

        public void DatabaseClose()
        {
            sqliteConnection.Close();
        }
    }
}
