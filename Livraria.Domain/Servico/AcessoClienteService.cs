using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using Livraria.Domain.Interfece.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Servico
{
    public class AcessoClienteService : ServiceBase<AcessoCliente>, IAcessoClienteService
    {
        private readonly IAcessoClienteRepository _AcessoClienteRepository;
        public AcessoClienteService(IAcessoClienteRepository acessoClienteRepository) : base(acessoClienteRepository)
        {
            _AcessoClienteRepository = acessoClienteRepository;

        }

        public void Add(AcessoCliente acessoCliente, int Id)
        {
            _AcessoClienteRepository.Add(acessoCliente, Id);
        }

        public IEnumerable<AcessoCliente> BuscaPorNome(string nome)
        {
            return _AcessoClienteRepository.BuscaPorNome(nome);
        }

        public AcessoCliente ClienteAutenticate(string email)
        {
            return _AcessoClienteRepository.ClienteAutenticate(email);
        }
    }
}
