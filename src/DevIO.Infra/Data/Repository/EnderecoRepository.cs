using System;
using System.Threading.Tasks;
using DevIO.Business.Models.Fornecedores;

namespace DevIO.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            //return await Db.Enderecos.AsNoTracking().FirstOrDefaultAsync(e => e.Id == fornecedorId);//id do endereço é PK e FK

            return await ObterPorId(fornecedorId);
        }
    }
}
