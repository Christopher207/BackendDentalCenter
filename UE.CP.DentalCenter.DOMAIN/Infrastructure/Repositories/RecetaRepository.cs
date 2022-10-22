﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

using UE.CP.DentalCenter.DOMAIN.Core.Interface;

namespace UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories
{
    public class RecetaRepository: IRecetaRepository
    {
        private readonly DentalCenterContext _context;
        public RecetaRepository(DentalCenterContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertReceta(DetRecetaMedica receta)//AñadirReceta
        {
            await _context.DetRecetaMedica.AddAsync(receta);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<bool> InsertCabReceta(CabRecetaMedica cabR)//AñadirCabReceta
        {
            await _context.CabRecetaMedica.AddAsync(cabR);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
    }
}
