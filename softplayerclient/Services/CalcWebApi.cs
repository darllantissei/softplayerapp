using Newtonsoft.Json;
using softplayerclient.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace softplayerclient.Services
{
    public class CalcWebApi
    {
        #region Eventos
        public delegate void ExceptionErro(object sender, Task exception);
        public event ExceptionErro OnExceptionErro;
        private void OnExceptionErroHandler(Task obj)
        {
            if (obj.Exception != null)
            {
                if (OnExceptionErro != null)
                    OnExceptionErro(this, obj);
            }
        }
        #endregion

        HttpClient httpClient;

        public Returns SolicitarCalculo(decimal valorInicial, int meses)
        {
            // Utilizando HttpClient para comunicação de alto nível
            using (httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = null;

                // Camo os métodos da classe HttpClient são assíncronos, vamos crias uma tarefa e forçá-la ser
                // síncrono para que possamos manipular em uma outra situação processos assíncronos
                Task.Run(async () =>
                {
                   httpResponseMessage = await httpClient.GetAsync($"{Properties.Resources.URL_API_CAL}?{Properties.Resources.PAR_VALOR_INICIAL}={valorInicial}&{Properties.Resources.PAR_MESES}={meses}");
                })
                .ContinueWith(OnExceptionErroHandler)
                .Wait();

                string retornoApi = string.Empty;
                Returns returns = null;
                switch (httpResponseMessage.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        {
                            // Forçar tarefa para síncrono
                            Task.Run(async () => 
                            {
                                retornoApi = await httpResponseMessage.Content.ReadAsStringAsync();
                            })
                            .ContinueWith(OnExceptionErroHandler)
                            .Wait();

                            if (!StringsUtil.StringIsNullOrEmptyOrWhiteSpace(retornoApi))
                                returns = JsonConvert.DeserializeObject<Returns>(retornoApi);
                        }
                        break;
                    case System.Net.HttpStatusCode.BadRequest:
                        {

                            // Forçar tarefa para síncrono
                            Task.Run(async () => 
                            {
                                retornoApi = await httpResponseMessage.Content.ReadAsStringAsync();
                            })
                            .ContinueWith(OnExceptionErroHandler)
                            .Wait();

                            if (!StringsUtil.StringIsNullOrEmptyOrWhiteSpace(retornoApi))
                                returns = JsonConvert.DeserializeObject<Returns>(retornoApi);
                        }
                        break;
                    case System.Net.HttpStatusCode.NotAcceptable:
                        {

                            // Forçar tarefa para síncrono
                            Task.Run(async () =>
                            {
                                retornoApi = await httpResponseMessage.Content.ReadAsStringAsync();
                            })
                            .ContinueWith(OnExceptionErroHandler)
                            .Wait();

                            if (!StringsUtil.StringIsNullOrEmptyOrWhiteSpace(retornoApi))
                                returns = JsonConvert.DeserializeObject<Returns>(retornoApi);
                        }
                        break;
                    default:
                        {
                            // Caso dê algum statuscode não tratato vamos retorno ele para que possa ser visível na aplicação
                            returns = new Returns
                            {
                                StatusCode = (int)httpResponseMessage.StatusCode,
                                Message = "Ocorre um erro!"
                            };
                        }
                        break;
                }

                return returns;
            }
        }

        
    }
}
