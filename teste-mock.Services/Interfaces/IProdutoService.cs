using teste_mock.Models.Entities;

namespace teste_mock.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto addProduto(int id, string nome, string marca);
    }
}
