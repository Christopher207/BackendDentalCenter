﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class TratamientoDTO
    {
        public int IdTratamiento { get; set; }
        public string? Tipo { get; set; }
        public int? DuracionDias { get; set; }
        public double? Precio { get; set; }
        public string? Descripcion { get; set; }
    }
}
