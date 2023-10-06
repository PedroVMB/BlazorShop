using BlazorShop.Models.DTOs;

namespace BlazorShop.Web.services
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDto>> GetItens(); 


    }
}
