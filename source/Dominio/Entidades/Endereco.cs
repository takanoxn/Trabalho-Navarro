﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int    Numero     { get; set; }
        public string Bairro     { get; set; }
        public string Cep        { get; set; }
        public string Cidade     { get; set; }
    }
}
