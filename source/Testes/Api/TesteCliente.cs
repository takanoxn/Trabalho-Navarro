using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiTeste2.Controllers;
using Dominio.Entidades;

namespace Testes.Api
{
    [TestClass]
    public class TesteCliente
    {
        [TestMethod]
        public void TesteBuscarCliente()
        {
            // Instância o controller Cliente
            ClienteController clienteController = new ClienteController();

            // Aplica o método
            var retornado = clienteController.GetCliente(1); 
      
            // Verifica se o cliente foi encontrado com sucesso
            Assert.AreNotEqual(null, retornado);
        }

        [TestMethod]
        public void TesteIncluirCliente()
        {
            // Instância o controller Cliente
            ClienteController clienteController = new ClienteController();

            // Instância o cliente 
            Cliente cliente = new Cliente
            {
                // Preenche os atributos do cliente
                Codigo = 9,
                Nome = "NOME TESTE",
                Telefone = "34001234",
                Email = "TESTE@TESTE.COM",
                Endereco = new Dominio.Entidades.Endereco
                {
                    Logradouro = "LOGRADOURO TESTE",
                    Numero = 1000,
                    Bairro = "BAIRRO TESTE",
                    Cep = "17511000",
                    Cidade = "MARILIA"
                }
            };

            // Aplica o método
            var retornado = clienteController.PostCliente(cliente);

            // Verifica se o cliente foi incluido com sucesso
            Assert.AreNotEqual(null, retornado);
        }
    }
}
