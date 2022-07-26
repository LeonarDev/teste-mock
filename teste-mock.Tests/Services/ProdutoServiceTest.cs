﻿using Moq;
using teste_mock.Models.Entities;
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

            service.AddProduto(id, nome, marca);

            repository.Verify(a => a.AddProduto(id, nome, marca),  Times.Once);
        }

        [Fact(DisplayName = "AddProduto: 02 - Deve retornar o valor recebido de repository.AddProduto")]
        public void AddProduto_02()
        {
            int id = 1;
            string nome = "Produto 01";
            string marca = "TDD";

            Produto produtoEsperado = new Produto()
            {
                Id = id,
                Nome = nome,
                Marca = marca
            };

            repository
                .Setup(a => a.AddProduto(id, nome, marca))
                .Returns(produtoEsperado);

            Produto produtoRetornado = service.AddProduto(id, nome, marca);

            Assert.Same(produtoEsperado, produtoRetornado);
        }
    }
}
