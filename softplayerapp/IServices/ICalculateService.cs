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
        decimal CalculateValues(decimal valorInicial, int meses, decimal juros);
    }
}
