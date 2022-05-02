using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using System.Collections.Generic;

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
        public interface IPostagem
        {
            void NovaPostagem(NovaPostagemDTO postagem);
            void AtualizarPostagem(AtualizarPostagemDTO postagem);
            void DeletarPostagem(int id);
            PostagemModelo PegarPostagemPeloId(int id);
            List<PostagemModelo> PegarTodasPostagens();
            List<PostagemModelo> PegarPostagemPeloTitulo(string titulo);
            List<PostagemModelo> PegarPostagemPelaDescricao(string descricao);

        }
    }
}
