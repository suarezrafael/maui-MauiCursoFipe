using MauiCursoFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiCursoFipe.Repositorios
{
    public class AnoRepositorio
    {
        public static List<Ano> ListarAnoCarro(string codigo,string TipoVeiculo,string CodCarro)
        {
            
            var url = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas/{codigo}/modelos/{CodCarro}/anos";
            var resposta = Util.HttpClientUtil.ConsHttpClientAsync(url);

            List<Ano> Ano = JsonSerializer.Deserialize<List<Ano>>(resposta.Result);

            return Ano;
        }

    }
}
