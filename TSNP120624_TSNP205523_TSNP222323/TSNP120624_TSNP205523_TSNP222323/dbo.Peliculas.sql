CREATE TABLE [dbo].[Peliculas] (
    [IdPelicula]    INT   IDENTITY (1, 1) NOT NULL,
    [Titulo]        NTEXT NOT NULL,
    [Autor]         NTEXT NOT NULL,
    [Duracion]      NTEXT NOT NULL,
    [Sinopsis]      NTEXT NOT NULL,
    [Clasificacion] NTEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPelicula] ASC)
);

