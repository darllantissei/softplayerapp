using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using softplayerapp.Class;
using softplayerapp.Util;
using softplayerapp.Validations;
using static softplayerapp.Class.Returns;

namespace softplayerapp.Controllers
{
    /// <summary>
    /// Controller para mostrar o endereço do github
    /// </summary>
    [Route("api/showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        /// <summary>
        /// Método Action para retornar a url do github
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            // Retornar github
            return Ok("https://github.com/darllantissei/softplayerapp");
        }        
    }
}
