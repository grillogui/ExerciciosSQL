﻿using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar uma nova Postagem</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary> 

    public class NovaPostagemDTO
    {
        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [Required, StringLength(30)]
        public string EmailCriador { get; set; }
        [Required]
        public string DescricaoTema { get; set; }

        public NovaPostagemDTO(string titulo, string descricao, string foto, string emailCriador, string descricaoTema)
        {
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            EmailCriador = emailCriador;
            DescricaoTema = descricaoTema;
        }
    }


    /// <summary>
    /// <para>Resumo: Classe espelho para atualizar uma postagem</para>
    /// <para>Criado por: Guilherme Grillo</para>
    /// <para>versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary> 

    public class AtualizarPostagemDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }
       
        [Required]
        public string DescricaoTema { get; set; }


        public AtualizarPostagemDTO(string titulo, string descricao, string foto, string descricaoTema, int id)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            DescricaoTema = descricaoTema;
        }
    }
}
