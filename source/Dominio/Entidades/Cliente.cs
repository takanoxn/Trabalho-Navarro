﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int      Codigo   { get; set; }
        public string   Nome     { get; set; }
        public string   Telefone { get; set; }
        public string   Email    { get; set; }
        public Endereco Endereco { get; set; }
    }
}
