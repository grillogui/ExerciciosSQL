using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
using System.Collections.Generic;

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
        List<TemaModelo> PegarTodosTemas();
        TemaModelo PegarTemaPeloId(int id);
        List<TemaModelo> PegarTemasPelaDescricao(string descricao);
        void NovoTema(NovoTemaDTO tema);
        void AtualizarTema(AtualizarTemaDTO tema);
        void DeletarTema(int id);

    }
}
