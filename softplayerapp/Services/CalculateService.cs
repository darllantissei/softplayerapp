using softplayerapp.Class;
using softplayerapp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayerapp.Services
{
    /// <summary>
    /// Micro-serviço para calcular juros
    /// </summary>
    public class CalculateService : ICalculateService
    {
        /// <summary>
        /// Método para realização de cálculo de juros composto
        /// </summary>
        /// <param name="valorInicial">valor inicial</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <param name="juros">Juros para aplicação do cálculo</param>
        /// <returns>Retorno o valor final</returns>
        public decimal CalculateValues(decimal valorInicial, int meses, decimal juros)
        {
            // Vamos calcular
            double valorFinal = 0f;

            valorFinal = (double)valorInicial * Math.Pow((1 + (double)juros), meses);

            valorFinal = Math.Truncate(100 * valorFinal) / 100;

            if (double.IsInfinity(valorFinal))
                return 0m;

            return (decimal)valorFinal;            
        }
    }
}
