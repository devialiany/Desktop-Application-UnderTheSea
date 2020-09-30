using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class DatabaseConnectionHandler
    {
        private static UnderTheSeaDBsEntities myDb;

        private DatabaseConnectionHandler() { }
        public static UnderTheSeaDBsEntities GetInstance() {
            if (myDb == null)
                myDb = new UnderTheSeaDBsEntities();
            return myDb;
        }
    }
}
