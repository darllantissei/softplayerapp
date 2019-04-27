using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayerapp.IServices
{
    /// <summary>
    /// Interface do Micro-serviço para calcular juros
    /// </summary>
    public interface ICalculateService
    {
        /// <summary>
        /// Método para realização de cálculo de juros composto
        /// </summary>
        /// <param name="valorInicial">valor inicial</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <param name="juros">Juros para aplicação do cálculo</param>
        /// <returns>Retorno o valor final</returns>
        decimal CalculateValues(decimal valorInicial, int meses, decimal juros);
    }
}
