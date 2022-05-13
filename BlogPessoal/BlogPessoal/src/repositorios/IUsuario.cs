using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogPessoal.src.repositorios
{

    /// <summary>
    /// <para>Resumo: Responsavvel por representar ações de CRUD de usuario</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>

    public interface IUsuario
    {
        Task NovoUsuarioAsync(NovoUsuarioDTO usuario);
        Task AtualizarUsuarioAsync(AtualizarUsuarioDTO usuario);
        Task DeletarUsuarioAsync(int id);
        Task<UsuarioModelo> PegarUsuarioPeloIdAsync(int id);
        Task<UsuarioModelo> PegarUsuarioPeloEmailAsync(string email);
        Task<List<UsuarioModelo>> PegarUsuariosPeloNomeAsync(string nome);


    }
}                     
