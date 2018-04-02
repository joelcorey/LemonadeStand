using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace LemonadeStand
{
    class Database : APIKey
    { 

        public void DatabaseConnect()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");

        }

        private void DatabaseSetup()
        {

        }
    }
}
