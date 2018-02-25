using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace MyWebAPI.ConexionDB
{
    public class Conexion
    {
        private DbCommand command;
        private DbConnection conection;
        private IDataReader read;

        public Conexion(DbConnection conection) { this.conection = conection; }

        public void open() { conection.Open(); }


        private void close() { conection.Close(); }
        public DataTable get_data(string query)
        {

            open();

            DataTable result = new DataTable();

            command = conection.CreateCommand();

            command.Connection = conection;
            command.CommandText = query;

            read = command.ExecuteReader();

            result.Load(read);
            read.Close();

            close();

            return result;

        }

    }
}
