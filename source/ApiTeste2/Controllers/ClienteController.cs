using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiTeste2.Controllers
{
    public class ClienteController : ApiController
    {
        // Função que Busca um cliente.
        public IHttpActionResult GetCliente(int codigo)
        {
            // Busca o primeiro Cliente com o código informado.
            var cliente = BancoDados.clientes.FirstOrDefault((p) => p.Codigo == codigo);

            // Verifica se retornou o cliente.
            if (cliente == null)
            {
                // Retorna que não foi encontrado o cliente com o código informado.
                return NotFound();
            }

            // Retorna o cliente com o código informado.
            return Ok(cliente);
        }

        // Função que Inclui um cliente.
        public IHttpActionResult PostCliente([FromBody] Cliente cliente)
        {
            // Verifica se o código do cliente informado é 0.
            if (cliente.Codigo == 0)
            {
                // Armazena na variável o ultimo código utilizado. 
                var ultimoIndice = BancoDados.clientes.OrderBy(x => x.Codigo).Last().Codigo;

                // Atribui ao cliente o proximo código disponível.
                cliente.Codigo = ultimoIndice + 1;
            }

            // Adiciono o cliente na "Memória" ou Lista.
            BancoDados.clientes.Add(cliente);

            // Retorna que o cliente foi adicionado com sucesso.
            return Ok(BancoDados.clientes);
        }
    }
}