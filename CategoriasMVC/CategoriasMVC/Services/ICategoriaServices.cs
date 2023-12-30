namespace CategoriasMVC.Services
{
    public interface ICategoriaServices
    {
        Task<IEnumerable<CategoriasMVC.Models.CategoriaViewModel>> GetCategorias();
        Task<CategoriasMVC.Models.CategoriaViewModel> GetCategoriaPorId(int id);
        Task<CategoriasMVC.Models.CategoriaViewModel> CriarCategoria(CategoriasMVC.Models.CategoriaViewModel categoriaVM);
        Task<bool> AtualizaCategoria(int id, CategoriasMVC.Models.CategoriaViewModel categoriaVM);
        Task<bool> DeletaCategoria(int id);

    }
}
