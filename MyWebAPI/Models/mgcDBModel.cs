using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebAPI.ConexionDB;
using MyWebAPI.Controllers;
using System.Data.SqlClient;
using System.Data;

namespace MyWebAPI.Models
{
    public class mgcDBModel
    {

        //Conexion coneccion = new Conexion(new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", "THE_BADM_DAVILA", "mgcDB")));

        Conexion coneccion = new Conexion(new SqlConnection("Data Source= localhost; Initial Catalog= mgcDB; Integrated Security=True"));


        Conexion coneccion2 = new Conexion(new SqlConnection("Data Source= localhost; Initial Catalog= DBConfiguration; Integrated Security=True"));


        public List<mgcDB> obtenerdatos()
        {
            List<mgcDB> students = new List<mgcDB>();

            DataTable TABLA = coneccion2.get_data("SELECT 'SELECT ' + RTRIM(sd.DescriptionCampo) + ' FROM ' + RTRIM(st.NameTable) + ' ' + sw.ConditionName FROM NameTable st inner join TableCampo sd on st.IDTable = sd.IDCampo inner join ConditionTable sw on st.IDTable = sw.IDCondition WHERE st.IDTable = 1");

            DataTable datos = coneccion.get_data(TABLA.Rows[0].ItemArray[0].ToString());


//            DataTable datos = coneccion.get_data("SELECT ID, Name, LastName, Address FROM students");

            foreach (DataRow x in datos.Rows)
            {
                mgcDB currmgcDB = new mgcDB();

                currmgcDB.ID = (int)x.ItemArray[0];
                currmgcDB.Name = (string)x.ItemArray[1];
                currmgcDB.LastName = (string)x.ItemArray[2];
                currmgcDB.Address = (string)x.ItemArray[3];

                students.Add(currmgcDB);

            }

            return students;

        }
    }
}