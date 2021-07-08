using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CAPA_NEGOCIO;

using Newtonsoft.Json;

namespace UIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        [HttpPost("PostSaveDocente")]
        public object PostSaveDocente(object NewD)
        {
            ClassDocente NewDocente = JsonConvert.DeserializeObject<ClassDocente>(NewD.ToString());          
            return NewDocente.Save(NewDocente);
            //return NewM;
        }
        [HttpPost("filtrarDocente")]
        public object filtrarDocente()
        {
            ClassDocente NewDocente = new ClassDocente();            
            return NewDocente.Filter();
        }
    }
}
