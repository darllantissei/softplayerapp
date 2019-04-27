using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softplayerclient.Util
{
    public static class StringsUtil
    {
        /// <summary>
        /// Verificar se a string é vazia ou contém espaços em branco
        /// </summary>
        /// <param name="texto">string que será utilizada para ser validada</param>
        /// <returns>se a string for vazio ou com espaços em banco retornará true senão false</returns>
        public static bool StringIsNullOrEmptyOrWhiteSpace(string texto)
        {
            if (string.IsNullOrEmpty(texto) || string.IsNullOrWhiteSpace(texto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
