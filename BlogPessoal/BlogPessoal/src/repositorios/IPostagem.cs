using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogPessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavvel por representar ações de CRUD de postagem</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    /// 
    public interface IPostagem
    {
        Task NovaPostagemAsync(NovaPostagemDTO postagem);
        Task AtualizarPostagemAsync(AtualizarPostagemDTO postagem);
        Task DeletarPostagemAsync(int id);
        Task<PostagemModelo> PegarPostagemPeloIdAsync(int id);
        Task<List<PostagemModelo>> PegarTodasPostagensAsync();
        Task<List<PostagemModelo>> PegarPostagensPorPesquisaAsync(string titulo, string descricaoTema, string nomeCriador);

    }

}
