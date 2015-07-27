using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Area
    {
        public int id { get; set; }

        [Required]
        [Display(Name="Nº da área")]
        public int codigo { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required]
        [Display(Name = "Número")]
        public string numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required]
        [Display(Name = "Quantidade de micro áreas")]
        public int quantMicroAreas{ set; get; }

        public virtual ICollection<MicroArea> MicroArea { get; set; }
   
    }
}
