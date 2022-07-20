using teste_mock.Models.Entities;

namespace teste_mock.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto addProduto(int id, string nome, string marca);
    }
}
