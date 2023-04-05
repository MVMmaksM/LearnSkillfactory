using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class Application
    {
        public dbConnection DbConnection { get; set; }

        public void Launch(string connectionString) 
        {
            DbConnection = dbConnection.GetConnectionInstatnce(connectionString);
        }
    }
}
