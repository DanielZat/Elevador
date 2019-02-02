using System.Collections.Generic;
using Elevador.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevador.API.Controllers
{
    [Route("api/Elevador")]
    [ApiController]
    public class ElevadorController : ControllerBase
    {
        private IElevadorService fServico;

        //INJECAO DE DEPENDENCIA
        public ElevadorController(IElevadorService pServico)
        {
            fServico = pServico;
        }

        [HttpGet]
        public string Get()
        {
            return "API Apisul - Desafio";
        }

        [HttpGet("AndarMenosUtilizado")]
        public List<int> AndarMenosUtilizado()
        {
            return fServico.andarMenosUtilizado();
        }

        [HttpGet("ElevadorMaisFrequentado")]
        public List<char> ElevadorMaisFrequentado()
        {
            return fServico.elevadorMaisFrequentado();
        }

        [HttpGet("ElevadorMenosFrequentado")]
        public List<char> ElevadorMenosFrequentado()
        {
            return fServico.elevadorMenosFrequentado();
        }

        [HttpGet("PercentualDeUsoElevadorA")]
        public float PercentualDeUsoElevadorA()
        {
            return fServico.percentualDeUsoElevadorA();
        }

        [HttpGet("PercentualDeUsoElevadorB")]
        public float PercentualDeUsoElevadorB()
        {
            return fServico.percentualDeUsoElevadorB();
        }

        [HttpGet("PercentualDeUsoElevadorC")]
        public float PercentualDeUsoElevadorC()
        {
            return fServico.percentualDeUsoElevadorC();
        }

        [HttpGet("PercentualDeUsoElevadorD")]
        public float PercentualDeUsoElevadorD()
        {
            return fServico.percentualDeUsoElevadorD();
        }

        [HttpGet("PercentualDeUsoElevadorE")]
        public float PercentualDeUsoElevadorE()
        {
            return fServico.percentualDeUsoElevadorE();
        }

        [HttpGet("PeriodoMaiorFluxoElevadorMaisFrequentado")]
        public List<char> PeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            return fServico.periodoMaiorFluxoElevadorMaisFrequentado();
        }

        [HttpGet("PeriodoMaiorUtilizacaoConjuntoElevadores")]
        public List<char> PeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            return fServico.periodoMaiorUtilizacaoConjuntoElevadores();
        }

        [HttpGet("PeriodoMenorFluxoElevadorMenosFrequentado")]
        public List<char> PeriodoMenorFluxoElevadorMenosFrequentado()
        {
            return fServico.periodoMenorFluxoElevadorMenosFrequentado();
        }
    }
}
