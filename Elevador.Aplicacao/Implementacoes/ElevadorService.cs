using System;
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
            var resultado = questionarios.GroupBy(g => g.Andar).OrderBy(o => o.Count()).Select(s => s.Key).ToList();
            return resultado.ToList();
        }

        public List<char> elevadorMaisFrequentado()
        {
            var resultado = questionarios.GroupBy(g => g.Elevador).OrderByDescending(o => o.Count()).Select(s => s.Key).ToList();
            return resultado.ToList();
        }

        public List<char> elevadorMenosFrequentado()
        {
            var resultado = questionarios.GroupBy(g => g.Elevador).OrderBy(o => o.Count()).Select(s => s.Key).ToList();
            return resultado.ToList();
        }

        public float percentualDeUsoElevadorA()
        {
            var resultado = questionarios.Where(w => w.Elevador == 'A').Select(s => s.Elevador).Count();
            return ((float)resultado / (float)questionarios.Count()) * 100;
        }

        public float percentualDeUsoElevadorB()
        {
            var resultado = questionarios.Where(w => w.Elevador == 'B').Select(s => s.Elevador).Count();
            return ((float)resultado / (float)questionarios.Count()) * 100;
        }

        public float percentualDeUsoElevadorC()
        {
            var resultado = questionarios.Where(w => w.Elevador == 'C').Select(s => s.Elevador).Count();
            return ((float)resultado / (float)questionarios.Count()) * 100;
        }

        public float percentualDeUsoElevadorD()
        {
            var resultado = questionarios.Where(w => w.Elevador == 'D').Select(s => s.Elevador).Count();
            return ((float)resultado / (float)questionarios.Count()) * 100;
        }

        public float percentualDeUsoElevadorE()
        {
            var resultado = questionarios.Where(w => w.Elevador == 'E').Select(s => s.Elevador).Count();
            return ((float)resultado / (float)questionarios.Count()) * 100;
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
