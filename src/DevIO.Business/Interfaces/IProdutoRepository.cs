using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        // retorna uma lista de produtos com base num fornecedor
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        
        // obtém todos os produtos e seus respectivos fornecedores
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        
        // obtém um produto e seu respectivo fornecedor
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
