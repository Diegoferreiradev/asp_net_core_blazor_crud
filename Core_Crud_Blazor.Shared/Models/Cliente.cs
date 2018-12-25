using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Core_Crud_Blazor.Shared.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Pais { get; set; }

        public string Estado { get; set; }
    }
}
