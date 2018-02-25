using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class mgcDBController : ApiController
    {
        mgcDB CurrmgcDB = new mgcDB();
        public List<mgcDB> Get()
        {
            return CurrmgcDB.obtenerlosdatos();
        }
    }
}
