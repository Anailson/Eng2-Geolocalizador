using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Classes
{
    public class Visita
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nº da visita")]
        public int codigo { get; set; }

        [Required]
        [Display(Name = "Nº do domicilio")]
        public int codDomicilio { get; set; }

        [Required]
        [Display(Name = "Data da visita")]
        public DateTime dataVisita { get; set; }

        [Display(Name = "Próxima visita")]
        public DateTime dataProxVisita { get; set; }

        [StringLength(20)]
        [Display(Name = "Melhor horário")]
        public string melhorHorario { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Resumo")]
        public string resumo { get; set; }

        [Required, StringLength(500)]
        [Display(Name = "Descrição")]
        public string detalhes { get; set; }


        public virtual Domicilio Domicilio { get; set; }
        public virtual ICollection<AcompanhamentoCrianca> AcompanhamentoCrianca { get; set; }
        public virtual ICollection<AcompanhamentoEnfermo> AcompanhamentoEnfermo { get; set; }
        public virtual ICollection<AcompanhamentoGestante> AcompanhamentoGestante { get; set; }

    }
}
