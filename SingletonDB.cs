using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    public sealed class SingletonDB
    {
        private static readonly SingletonDB instance = new SingletonDB();
        private readonly DB_VehiculesEntities db = new DB_VehiculesEntities();

        static SingletonDB()
        {
        }

        private SingletonDB()
        {
        }

        public static SingletonDB Instance
        {
            get
            {
                return instance;
            }
        }

        public DB_VehiculesEntities GetDBConnection()
        {
            return db;
        }
    }
}
