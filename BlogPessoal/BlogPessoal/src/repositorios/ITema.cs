using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogPessoal.src.repositorios
{

    /// <summary>
    /// <para>Resumo: Responsavvel por representar ações de CRUD do tema</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>

    public interface ITema
    {
        Task<List<TemaModelo>> PegarTodosTemasAsync();
        Task<TemaModelo> PegarTemaPeloIdAsync(int id);
        Task<List<TemaModelo>> PegarTemasPelaDescricaoAsync(string descricao);
        Task NovoTemaAsync(NovoTemaDTO tema);
        Task AtualizarTemaAsync(AtualizarTemaDTO tema);
        Task DeletarTemaAsync(int id);

    }
}
