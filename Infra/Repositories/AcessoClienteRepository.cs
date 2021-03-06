using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace Infra.Repositories
{
    public class AcessoClienteRepository : RepositoryBase<AcessoCliente>, IAcessoClienteRepository
    {
        public void Add(AcessoCliente acessoCliente, int Id)
        {
            var clinete = Db.Clientes.Find(Id);
           // acessoCliente.AcessoClienteId = Id;
            
            Db.AcessoClientes.Add(acessoCliente);
            Db.SaveChanges();
        }

        public AcessoCliente ClienteAutenticate(string email)
        {
            return Db.AcessoClientes.Where(c => c.Email.Trim() == email.Trim()).FirstOrDefault();
        }

        IEnumerable<AcessoCliente> IAcessoClienteRepository.BuscaPorNome(string email)
        {
            return Db.AcessoClientes.Where(c => c.Email.Trim() == email.Trim()).AsQueryable().OrderBy(c=>c.Email).ToList();
        }
    }
}
