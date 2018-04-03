using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace LemonadeStand
{
    class Database
    {
        //http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/

        public SQLiteConnection sqliteConnection;
        public SQLiteCommand sqliteCommand;
        public SQLiteDataReader sqliteRead;

        public void DatabaseConnect(string connectionString)
        {
            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();
        }

        public void DatabaseDoCommand(string sql)
        {
            sqliteCommand = new SQLiteCommand(sql, sqliteConnection);
            sqliteCommand.ExecuteNonQuery();
        }

        public void DatabaseShowScore(string sql)
        {
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
