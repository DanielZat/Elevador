using System.Collections.Generic;
using System.IO;
using System.Linq;
using Elevador.Aplicacao.Interfaces;
using Elevador.Dominio.Entidades;
using Newtonsoft.Json;

namespace Elevador.Aplicacao.Implementacoes
{
    public class ElevadorService : IElevadorService
    {
        List<Questionario> questionarios = new List<Questionario>();

        public ElevadorService()
        {
            using (StreamReader r = new StreamReader("../Elevador.Dominio/dados.json"))
            {
                var json = r.ReadToEnd();
                questionarios = JsonConvert.DeserializeObject<List<Questionario>>(json);
            }
        }

        public List<int> andarMenosUtilizado()
        {
            var resultado = questionarios.Select(q => q.Andar);


            return resultado.ToList();
        }

        public List<char> elevadorMaisFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public List<char> elevadorMenosFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorA()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new System.NotImplementedException();
        }
    }
}
