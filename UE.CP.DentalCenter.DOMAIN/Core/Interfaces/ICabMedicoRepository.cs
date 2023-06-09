﻿using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface ICabMedicoRepository
    {
        Task<IEnumerable<CabMedico>> GetMedicos();
        Task<IEnumerable<CabMedico>> GetMedicosByIdEspecialidad(int id);
        Task<IEnumerable<CabMedico>> GetMedicosByNombreEspecialidad(string especialidad);
        Task<CabMedico> GetMedicosById(int id);

        //Task<IEnumerable<CabMedico>> GetMedicosWithEspecialidadWithHorario();
        Task<bool> InsertCabMedico(CabMedico cabM);
        Task<bool> Delete(int id);
        Task<bool> Update(CabMedico cabMedico);
    }
}