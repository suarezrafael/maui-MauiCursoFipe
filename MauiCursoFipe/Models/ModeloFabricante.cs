﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCursoFipe.Models
{
    public class modeloFabricante
    {
        public List<modelos> modelos { get; set; }
    }


    public class modelos
    {
        public string nome { get; set; }

        public string codigo { get; set; }
    }


}
