using Microsoft.AspNetCore.Http;
using softplayerapp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayerapp.Validations
{
    /// <summary>
    /// Classe estática para métodos de validação de atributos
    /// </summary>
    public static class Verifications
    {
        /// <summary>
        /// Método responsável por verificar se algum valores que for passado por parâmetro está nulo
        /// </summary>
        /// <param name="values">Valores que deverão ser verificados</param>
        /// <returns>Retornará verdadeiro se encontrar valor nulo, caso contrário retorna false, indicando que os valores estão ok</returns>
        public static bool ValuesIsNull(object[] values)
        {
            foreach (object item in values)
            {
                if (item == null)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Método estático para verificar se a requisição informou mais de 1 parametro com mesmo nome
        /// </summary>
        /// <param name="parameters">Query com parâmetros</param>
        /// <returns>Retornará verdadeiro se existir apenas 1 parametro, caso contrário irá retornar false isso quer dizer que não é aceito vários parametros com mesmo nome</returns>
        public static bool AllowOnlyOneParameter(IQueryCollection parameters, string nomeParametro)
        {
            if (parameters[nomeParametro].Count > 1)
                return  false;

            return true;

        }
    }
}
