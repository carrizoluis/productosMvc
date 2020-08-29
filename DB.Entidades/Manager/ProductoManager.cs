using DB.Entidades.Context;
using DB.Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Entidades.Manager
{
    public class ProductoManager
    {
        private DbConnection DataBaseConnection;
        public ProductoManager(DbConnection dbConnection)
        {
            this.DataBaseConnection = dbConnection;
        }

        public Producto Insert(Producto p)
        {
            DataBaseConnection.Add(p);
            

            if (DataBaseConnection.SaveChanges() == 0)
            {
                return null;
            }

            return p;
        }

    }
}
