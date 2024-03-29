﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; internal set; }

        [Required(ErrorMessage ="O campo titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        
        [StringLength(30,ErrorMessage = "O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1,600,ErrorMessage ="A duração deve ter no minimo 1 e máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
