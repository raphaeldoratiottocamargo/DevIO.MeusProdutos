using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores.Services
{
    /// <summary>
    /// Camada utilizada apenas para as ações que modificam o estado da entidade.
    /// Para obter dados do banco, utilizar diretamente o Repositório, não devemos
    /// repetir as mesmas coisas, ou repassar o pedido, apenas para amontoar camadas
    /// </summary>
    public interface IFornecedorService : IDisposable
    {

        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);

    }
}
