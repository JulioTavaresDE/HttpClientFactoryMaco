using CategoriasMVC.Models;
using CategoriasMVC.Models;

namespace CategoriasMVC.Services
{
    public interface IAutenticacao
    {
        Task<TokenViewModel> AutenticaUsuario(UsuarioViewModel usuarioModel);

    }
}
