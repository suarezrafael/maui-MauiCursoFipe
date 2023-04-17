using MauiCursoFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiCursoFipe.Repositorios
{
    public class PesquisaRepositorio
    {
        public static pesquisaPreco RetonaDadosCarro(string codigo,
                                                     string TipoVeiculo,
                                                     string CodCarro,
                                                     string AnoCarro)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas/{codigo}/modelos/{CodCarro}/anos/{AnoCarro}";
            var resposta = Util.HttpClientUtil.ConsHttpClientAsync(url);

            pesquisaPreco preco = JsonSerializer.Deserialize<pesquisaPreco>(resposta.Result);

            return preco;
        }
    }
}
