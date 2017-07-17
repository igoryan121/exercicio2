using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoComercial.Web.Models
{
    [Table("Banco de dados)]
    public partial class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Stringlengh(255)]
        public string NomeCompetoRazaoSocial;

        [Required]
        [Stringlengh(255)]
        public string ApelidoNomeFantasia;

        [Required]
        [Stringlengh(15)]
        public string CPFCNPJ;
    }
}