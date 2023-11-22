﻿
using XPaymentsProject.Domain.Entities;

namespace XPaymentsProject.Application.Interfaces
{
    public interface IProdutoApplicationService
    {
        Task AddProduto(string nome, string descricao, string foto, int garantia, string emailSuporte);
        Task UpdateProduto(int id, Produto produto);
        Task DeleteProduto(int id);
        Task<Produto> GetProdutoById(int id);
        Task<Produto> GetAllProdutos();
    }
}
