using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class dbConnection
    {
        private static dbConnection _dbConnection;

        public string? ConnectionString { get; private set; }

        private dbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static dbConnection GetConnectionInstatnce(string connectionString)
        {
            if (_dbConnection is null)
                _dbConnection = new dbConnection(connectionString);            
            return _dbConnection;
        }
    }
}
