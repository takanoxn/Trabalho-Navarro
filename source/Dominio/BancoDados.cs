using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class BancoDados
    {
        // Simula o banco de dados.
        public static List<Cliente> clientes = new List<Cliente>
        { 
            new Cliente { Codigo = 1, Nome = "JORGE TAKANO JUNIOR", Telefone = "988343214", Email = "TAKANO.XN@GMAIL.COM",       Endereco = new Endereco { Logradouro = "BELARMINO RIBEIRO", Numero = 42, Cep = "17511-530", Bairro = "FERNANDO MAURO",         Cidade = "MARILIA" } }, 
            new Cliente { Codigo = 2, Nome = "ANDERSON MIYADA",     Telefone = "988340644", Email = "ANDERSONBCC2013@GMAIL.COM", Endereco = new Endereco { Logradouro = "REPUBLICA",         Numero = 22, Cep = "17511-531", Bairro = "PROLONGAMENTO PALMITAL", Cidade = "MARILIA" } }, 
        };
    }
}
