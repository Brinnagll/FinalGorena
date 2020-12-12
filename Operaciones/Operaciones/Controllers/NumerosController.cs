using Operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Operaciones.Controllers
{
    [RoutePrefix("api/operaciones")]
    public class NumerosController : ApiController
    {
        [HttpGet]
        [Route("{number:int}")]
        public Numero Operations(int number)
        {
            Numero model = new Numero();
            model.numero = number;

            if (number < 0)
                model.mensaje = "ERROR";

            if (number == 0)
                model.mensaje = "Realizado por Brinna Gorena";

            if (number > 0)
                model.mensaje = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";

            return model;
        }
    }
}
