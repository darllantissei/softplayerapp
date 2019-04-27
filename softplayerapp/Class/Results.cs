using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayerapp.Class
{
    /// <summary>
    /// Classe responsável por retornar os valores processados pelo servidor, irá fazer um parse para JSON
    /// </summary>
    public class Returns
    {
        /// <summary>
        /// Irá informar o HttpStatusCode
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Retornará uma mensagem
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Classe para obter o calculo
        /// </summary>
        [JsonProperty("result")]
        public Calculation Calc { get; set; }

        /// <summary>
        /// Classe para obter o calculo
        /// </summary>
        public class Calculation
        {
            /// <summary>
            /// Propriedade para informar o valor padrão
            /// </summary>
            [JsonProperty("valor_final")]
            public string ValorFinal { get; set; }

        }
    }
}
