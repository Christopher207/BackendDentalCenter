﻿CREATE TABLE [dbo].[DET_HISTORIA_MEDICA]
(
	[idDetHistoriaMedica] int IDENTITY NOT NULL,
    [idHistoriaMedica] int not null,
    [idCita] int NULL,
	[idMedico] int NOT NULL,
    [idAsistente] int NOT NULL,
	[idRecetaMedica] int NULL,
	[idTratamiento] int NULL,
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_CAB_RECETA_MEDICA] FOREIGN KEY ([idRecetaMedica]) REFERENCES [CAB_RECETA_MEDICA]([idRecetaMedica]), 
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_TRATAMIENTO] FOREIGN KEY ([idTratamiento]) REFERENCES [TRATAMIENTO]([idTratamiento]), 
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_CITA] FOREIGN KEY ([idCita]) REFERENCES [CITA]([idCita]), 
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_Medico] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]), 
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_PERSONAL_ADM] FOREIGN KEY ([idAsistente]) REFERENCES [PERSONAL_ADM]([idAsistente]), 
    CONSTRAINT [PK_DET_HISTORIA_MEDICA] PRIMARY KEY ([idDetHistoriaMedica]), 
    CONSTRAINT [FK_DET_HISTORIA_MEDICA_CAB_HISTORIA_MEDICA] FOREIGN KEY ([idHistoriaMedica]) REFERENCES [CAB_HISTORIA_MEDICA]([idHistoriaMedica]),
)
