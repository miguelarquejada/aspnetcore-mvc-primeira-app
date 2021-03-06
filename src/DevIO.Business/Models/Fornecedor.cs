using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        // 1 para 1
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        // EF Relation
        // 1 para muitos
        public IEnumerable<Produto> Produtos{ get; set; }
    }
}
