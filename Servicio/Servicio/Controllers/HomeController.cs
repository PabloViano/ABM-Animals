using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entidades;
using Logica;

namespace Servicio.Controllers
{
    [RoutePrefix("api/Animales/{ID}")] 
    public class AnimalController : ApiController
    {
        Logica.Class1 logica = new Logica.Class1();
        [Route("Alta")]
        public IHttpActionResult Get (string nombre, string especie)
        {
            if (logica.Alta(nombre, especie) != null) { logica.Alta(nombre, especie); return Ok(logica.Animales); }
            return NotFound();
        }
        [Route("Baja/{idAnimal}")]
        public IHttpActionResult BajaServicio (int id)
        {
            if (logica.Baja(id) != null) { logica.Baja(id); return Ok(logica.Animales); }
            return NotFound();
        }
        [Route("Modificacion")]
        public IHttpActionResult ModificacionServicio (Modificacion mod)
        {
            if (logica.Modificacion(mod) != null) { logica.Modificacion(mod); return Ok(logica.Animales); }
            return NotFound();
        }
    }
}
