using MauiCursoFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiCursoFipe.Repositorios
{
    public class FabricanteRespositorio
    {
        public static List<Fabricante> ListarFabricantes(string TipoVeiculo)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas";
            var resposta =Util.HttpClientUtil.ConsHttpClientAsync(url);

            List<Fabricante> fabricantes = JsonSerializer.Deserialize<List<Fabricante>>(resposta.Result);    

            return fabricantes;
        }
    }
}
