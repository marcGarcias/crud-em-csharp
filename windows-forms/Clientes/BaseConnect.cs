using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    internal class BaseConnect
    {
        private const string serverName = "localhost";
        private const string dataBase = "dbclientes";
        private const string userName = "root";
        private const string serverPass = "1234";

        static public string dbConnect = $"server={serverName}; user id={userName}; database={dataBase}; password={serverPass}";
    }
}
