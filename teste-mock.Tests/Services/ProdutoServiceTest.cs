using Moq;
using teste_mock.Repository.Interfaces;
using teste_mock.Services;
using teste_mock.Services.Interfaces;

namespace teste_mock.Tests.Services
{
    public class ProdutoServiceTest
    {
        private readonly IProdutoService service;
        private readonly Mock<IProdutoRepository> repository;

        public ProdutoServiceTest()
        {
            repository = new Mock<IProdutoRepository>();
            service = new ProdutoService(repository.Object);
        }

        [Fact(DisplayName = "AddProduto: 01 - Deve utilizar repository.AddProduto")]
        public void AddProduto_01()
        {
            int id = 1;
            string nome = "Produto 01";
            string marca = "TDD";

            service.addProduto(id, nome, marca);

            repository.Verify(a => a.addProduto(id, nome, marca),  Times.Once);
        }
    }
}
