using System;
using System.Data.SQLite;
using System.IO;

namespace ABCamel
{
    internal class ABCDatabase
    {
        string databasePath;
        SQLiteConnection connection;
        internal void Open()
        {
            databasePath = Directory.GetCurrentDirectory() + "ABCDatabase.sqlite";
            if (newConnect())
            {
                //TODO create data tables
            }
        }
        private bool newConnect()
        {
            bool isNew = false;
            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);
                isNew = true;
            }
            connection = new SQLiteConnection(openDataBaseString());
            connection.Open();
            return isNew;
        }

        private string openDataBaseString()
        {
            return "Data Source=" + databasePath + ";versiom = 3;";
        }
    }
}