CREATE TABLE [dbo].[Productos] (
    [IdProducto]   INT             IDENTITY (1, 1) NOT NULL,
    [Codigo]       CHAR (50)       NOT NULL,
    [Nombre]       CHAR (100)      NOT NULL,
    [Marca]        CHAR (30)       NOT NULL,
    [Presentacion] CHAR (100)      NULL,
    [Precio]       DECIMAL (10, 2) NOT NULL,
    [Stock]        CHAR (20)       NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);

