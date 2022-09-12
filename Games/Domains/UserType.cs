﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Games.Domains
{
    [Table("UserTypes")]
    public class UserType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUserType { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required(ErrorMessage = "O título do tipo de usuário é obrigatório!")]
        public string Title { get; set; } = string.Empty;
    }
}
