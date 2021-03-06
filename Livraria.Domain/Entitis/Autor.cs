using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entitis
{
   public  class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
        public virtual ICollection<Editora> Editoras { get; set; }
    }
}
