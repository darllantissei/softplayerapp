using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using softplayerapp.Class;
using softplayerapp.IServices;
using softplayerapp.Util;
using softplayerapp.Validations;
using static softplayerapp.Class.Returns;

namespace softplayerapp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        private readonly ICalculateService _calculate;

        public CalculoController(ICalculateService calculate)
        {
            _calculate = calculate;
        }

        [HttpGet]
        public ActionResult Get()
        {
            // Acesso inicial
            return StatusCode((int)HttpStatusCode.OK,
                JsonConvert.SerializeObject(new Returns
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Message = "Seja bem-vindo ao calculo API!"
                }));
        }

        [HttpGet, Route("calculajuros")]
        public ActionResult JurosComposto()
        {
            // Validações da requisição
            if (!RequestValidate(out Returns ret))
                return StatusCode(ret.StatusCode, JsonConvert.SerializeObject(ret));

            // Calcular
            ret = CalculateValues();            

            // Retornar o resultado
            return StatusCode((int)HttpStatusCode.OK,
                JsonConvert.SerializeObject(ret));
        }

        private Returns CalculateValues()
        {
            decimal valorFinal = _calculate.CalculateValues(decimal.Parse(this.Request.Query[Constants.PAR_VALOR_INICAL]),
                int.Parse(this.Request.Query[Constants.PAR_MESES]),
                Constants.JUROS);

            return new Returns
            {
                StatusCode = (int)HttpStatusCode.OK,
                Message = $"Os parâmetros {Constants.PAR_VALOR_INICAL} = {decimal.Parse(this.Request.Query[Constants.PAR_VALOR_INICAL])} e {Constants.PAR_MESES} = {this.Request.Query[Constants.PAR_MESES]}",
                Calc = new Calculation
                {
                    ValorFinal = string.Format("{0:n2}", (decimal)valorFinal)
                }
            };
        }



        /// <summary>
        /// Método responsável pela validações dos parâmetros
        /// </summary>
        /// <param name="ret">objeto de saída Returns com statuscode e mensagens de validação</param>
        /// <see cref="Returns"/>
        /// <returns>Retorna true indicando que as informações estão validadas para uso, retornará false caso encontre alguma inconsistência</returns>
        private bool RequestValidate(out Returns ret)
        {
            if (this.Request.Query.Count == 0)
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = "Nenhum valor informado para calculo!"
                };
                return false;
            }

            if (this.Request.Query[Constants.PAR_VALOR_INICAL].Count == 0)
            {
                ret = new Returns
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest,
                        Message = $"O parâmetros {Constants.PAR_VALOR_INICAL} é obrigatório"
                    };
                return false;
            }

            if (this.Request.Query[Constants.PAR_MESES].Count == 0)
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = $"O parâmetros {Constants.PAR_MESES} é obrigatório"
                };
                return false;
            }

            if (!Verifications.AllowOnlyOneParameter(this.Request.Query, Constants.PAR_MESES))
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.NotAcceptable,
                    Message = $"O parâmetro {Constants.PAR_MESES} foi informado diversas vezes, favor informar apenas um parâmetro"
                };

                return false;
            }

            if (!Verifications.AllowOnlyOneParameter(this.Request.Query, Constants.PAR_VALOR_INICAL))
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.NotAcceptable,
                    Message = $"O parâmetro {Constants.PAR_VALOR_INICAL} foi informado diversas vezes, favor informar apenas um parâmetro"
                };
                    
                return false;
            }

            if (!decimal.TryParse(this.Request.Query[Constants.PAR_VALOR_INICAL].ToString(), out decimal valorInicial))
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = "Valor inicial informado é inválido"
                };
                return false;
            }

            if (!int.TryParse(this.Request.Query[Constants.PAR_MESES].ToString(), out int mes))
            {
                ret = new Returns
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = "Meses informado é inválido"
                };
                return false;
            }

            ret = new Returns { StatusCode = (int)HttpStatusCode.OK, Message = string.Empty };
            return true;
        }
    }
}
