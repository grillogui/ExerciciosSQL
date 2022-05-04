using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.dtos
{

    /// <summary>
    /// <para>Resumo: Classe espelho para criar um novo tema</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary> 

    public class NovoTemaDTO
    {
        [Required, StringLength(30)]
        public string Descricao { get; set; }


        public NovoTemaDTO(string descricao)
        {
            Descricao = descricao;
        }
    }


    /// <summary>
    /// <para>Resumo: Classe espelho para atualizar um tema</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary> 

    public class AtualizarTemaDTO
    {
        [Required]
        public int id { get; set; }

        [Required, StringLength(30)]
        public string Descricao { get; set; }


        public AtualizarTemaDTO(string descricao)
        {
            Descricao = descricao;
        }
    }
}
