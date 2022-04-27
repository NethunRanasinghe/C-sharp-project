using System;

namespace form4
{
    internal class MySqlCommand
    {
        private string insertQuery;
        private MySqlConnection connection;

        public MySqlCommand(string insertQuery, MySqlConnection connection)
        {
            this.insertQuery = insertQuery;
            this.connection = connection;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}