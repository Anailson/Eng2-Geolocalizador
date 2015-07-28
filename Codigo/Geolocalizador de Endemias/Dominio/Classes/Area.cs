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

        [Required, StringLength(50)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required, StringLength(4)]
        [Display(Name = "Número")]
        public string numero { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [StringLength(13)]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required]
        [Display(Name = "Quantidade de micro áreas")]
        public int quantMicroAreas{ set; get; }

        public virtual ICollection<MicroArea> MicroArea { get; set; }
   
    }
}
