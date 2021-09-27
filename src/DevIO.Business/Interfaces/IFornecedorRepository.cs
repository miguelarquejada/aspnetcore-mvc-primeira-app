using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        // obtém o forncedor e o endereço dele
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        
        // obtém o forncedor, sua lista de produtos e seu endereço
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
