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
            var elevadoresMaisFrequentados = elevadorMaisFrequentado();

            var resultado = questionarios.Where(w => w.Elevador == elevadoresMaisFrequentados[0]).GroupBy(g => g.Turno).OrderByDescending(o => o.Count()).Select(s => s.Key).ToList();
            return resultado.ToList();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            var resultado = questionarios.GroupBy(g => g.Turno).OrderByDescending(o => o.Count()).Select(s => s.Key).ToList();
            return resultado.ToList();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {     
            var elevadoresMenosFrequentados = elevadorMenosFrequentado();

            Dictionary<char, int> turnos = new Dictionary<char, int>();
            turnos.Add('M', questionarios.Where(w => w.Elevador == elevadoresMenosFrequentados[0] && w.Turno == 'M').Count());
            turnos.Add('V', questionarios.Where(w => w.Elevador == elevadoresMenosFrequentados[0] && w.Turno == 'V').Count());
            turnos.Add('N', questionarios.Where(w => w.Elevador == elevadoresMenosFrequentados[0] && w.Turno == 'N').Count());
            
            var resultado = turnos.OrderBy(x => x.Value).Select(x => x.Key);
            return resultado.ToList();
        }
    }
}
