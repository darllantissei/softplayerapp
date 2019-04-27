using softplayerapp.IServices;
using softplayerapp.Services;
using System;
using Xunit;

namespace softplayerapp.tests
{
    public class UTestsCalcApi
    {
        private readonly ICalculateService _calculateService;
        public UTestsCalcApi()
        {
            _calculateService = new CalculateService();
        }

        [Fact]
        public void ResultadoIgualZero()
        {
            decimal valorInicial = 0m;
            int meses = 0;
            decimal juros = Util.Constants.JUROS;
            decimal valorFinal = _calculateService.CalculateValues(valorInicial, meses, juros);
            Assert.Equal(0, valorFinal);            
        }

        [Fact]
        public void RetornarValorInicialQuandoMesZero()
        {
            decimal valorInicial = 10m;
            int meses = 0;
            decimal juros = Util.Constants.JUROS;
            decimal valorFinal = _calculateService.CalculateValues(valorInicial, meses, juros);
            Assert.Equal(valorInicial, valorFinal);
        }

        [Fact]
        public void RetornarValorInicalQuandoJurosZero()
        {
            decimal valorInical = 100m;
            int meses = 5;
            decimal juros = 0m;
            decimal valorFinal = _calculateService.CalculateValues(valorInical, meses, juros);
            Assert.Equal(valorInical, valorFinal);
        }
    }
}
