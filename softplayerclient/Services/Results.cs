using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayerclient.Services
{
    /// <summary>
    /// Classe responsável por retornar os valores processados pelo servidor, irá fazer um parse para JSON
    /// </summary>
    public class Returns
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public Calculation Calc { get; set; }

        public class Calculation
        {
            [JsonProperty("valor_final")]
            public string ValorFinal { get; set; }

        }
    }
}
