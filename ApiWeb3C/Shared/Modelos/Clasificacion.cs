using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos
{
    public class Clasificacion
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string? Nombre { get; set; }

        virtual public ICollection<Persona>? Personas { get; set; }

    }
}
