using MauiCursoFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCursoFipe.Repositorios
{
    public class VeiculoRepositorios
    {
        public static List<Veiculo> ListarVeiculos()
        {
            List<Veiculo> lveiculos = new List<Veiculo>() 
            {
                new Veiculo(){Id=1,Tipo="carros" } ,
                new Veiculo(){Id=2,Tipo="motos" } ,
                new Veiculo(){Id=3,Tipo="caminhoes" } ,

            };

            return lveiculos;
        }

    }
}
