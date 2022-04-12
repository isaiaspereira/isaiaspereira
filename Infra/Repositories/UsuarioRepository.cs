﻿using Livraria.Domain.Entitis;
using Livraria.Domain.Interfece.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscaPorNome(string nome)
        {
            return BuscaPorNome(nome);
        }
    }
}
