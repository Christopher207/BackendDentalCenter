﻿using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class CabHistoriaMedica
    {
        public CabHistoriaMedica()
        {
            DetHistoriaMedica = new HashSet<DetHistoriaMedica>();
        }

        public int IdHistoriaMedica { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime? FechaDeActualizacion { get; set; }

        public virtual Paciente? IdPacienteNavigation { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
    }
}
