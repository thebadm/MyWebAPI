using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    public class mgcDB
    {
        private mgcDBModel data = new mgcDBModel();

        public int ID { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        public List<mgcDB> obtenerlosdatos()
        {
            return data.obtenerdatos();
        }
    }
}