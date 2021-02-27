
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2021 11:50:13
-- Generated from EDMX file: C:\Users\USER\source\repos\Intertazz\Intertazz.Data\EFIntertazzModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDIntertazz];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Marca'
CREATE TABLE [dbo].[Marca] (
    [IdMarca] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [IdFacturas] bigint IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Descuento] float  NOT NULL,
    [ValorTotal] float  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Stock'
CREATE TABLE [dbo].[Stock] (
    [IdInventario] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Producto'
CREATE TABLE [dbo].[Producto] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [Referencia] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Marca_IdMarca] int  NOT NULL,
    [ProductoInventario_Producto_IdInventario] int  NOT NULL,
    [Categoria_IdCategoria] int  NOT NULL,
    [TipoProducto_IdTipoProcuto] int  NOT NULL,
    [EntradasProducto_Producto_IdInventario] int  NOT NULL
);
GO

-- Creating table 'Precio'
CREATE TABLE [dbo].[Precio] (
    [IdPrecio] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Activo] bit  NOT NULL,
    [Producto_IdProducto] int  NOT NULL
);
GO

-- Creating table 'TipoProducto'
CREATE TABLE [dbo].[TipoProducto] (
    [IdTipoProcuto] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Caja] bit  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Inventario'
CREATE TABLE [dbo].[Inventario] (
    [IdInventario] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'DetalleFacturas'
CREATE TABLE [dbo].[DetalleFacturas] (
    [IdDetalleFacturas] bigint IDENTITY(1,1) NOT NULL,
    [ValorDetalle] float  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Activo] bit  NOT NULL,
    [Producto_IdProducto] int  NOT NULL,
    [Precio_IdPrecio] int  NOT NULL,
    [Facturas_IdFacturas] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdMarca] in table 'Marca'
ALTER TABLE [dbo].[Marca]
ADD CONSTRAINT [PK_Marca]
    PRIMARY KEY CLUSTERED ([IdMarca] ASC);
GO

-- Creating primary key on [IdFacturas] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([IdFacturas] ASC);
GO

-- Creating primary key on [IdInventario] in table 'Stock'
ALTER TABLE [dbo].[Stock]
ADD CONSTRAINT [PK_Stock]
    PRIMARY KEY CLUSTERED ([IdInventario] ASC);
GO

-- Creating primary key on [IdProducto] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [PK_Producto]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdPrecio] in table 'Precio'
ALTER TABLE [dbo].[Precio]
ADD CONSTRAINT [PK_Precio]
    PRIMARY KEY CLUSTERED ([IdPrecio] ASC);
GO

-- Creating primary key on [IdTipoProcuto] in table 'TipoProducto'
ALTER TABLE [dbo].[TipoProducto]
ADD CONSTRAINT [PK_TipoProducto]
    PRIMARY KEY CLUSTERED ([IdTipoProcuto] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdInventario] in table 'Inventario'
ALTER TABLE [dbo].[Inventario]
ADD CONSTRAINT [PK_Inventario]
    PRIMARY KEY CLUSTERED ([IdInventario] ASC);
GO

-- Creating primary key on [IdDetalleFacturas] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [PK_DetalleFacturas]
    PRIMARY KEY CLUSTERED ([IdDetalleFacturas] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Marca_IdMarca] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_MarcaProducto]
    FOREIGN KEY ([Marca_IdMarca])
    REFERENCES [dbo].[Marca]
        ([IdMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaProducto'
CREATE INDEX [IX_FK_MarcaProducto]
ON [dbo].[Producto]
    ([Marca_IdMarca]);
GO

-- Creating foreign key on [ProductoInventario_Producto_IdInventario] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_ProductoInventario]
    FOREIGN KEY ([ProductoInventario_Producto_IdInventario])
    REFERENCES [dbo].[Stock]
        ([IdInventario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoInventario'
CREATE INDEX [IX_FK_ProductoInventario]
ON [dbo].[Producto]
    ([ProductoInventario_Producto_IdInventario]);
GO

-- Creating foreign key on [Producto_IdProducto] in table 'Precio'
ALTER TABLE [dbo].[Precio]
ADD CONSTRAINT [FK_PrecioProducto]
    FOREIGN KEY ([Producto_IdProducto])
    REFERENCES [dbo].[Producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrecioProducto'
CREATE INDEX [IX_FK_PrecioProducto]
ON [dbo].[Precio]
    ([Producto_IdProducto]);
GO

-- Creating foreign key on [Categoria_IdCategoria] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_CategoriaProducto]
    FOREIGN KEY ([Categoria_IdCategoria])
    REFERENCES [dbo].[Categoria]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaProducto'
CREATE INDEX [IX_FK_CategoriaProducto]
ON [dbo].[Producto]
    ([Categoria_IdCategoria]);
GO

-- Creating foreign key on [TipoProducto_IdTipoProcuto] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_TipoProductoProducto]
    FOREIGN KEY ([TipoProducto_IdTipoProcuto])
    REFERENCES [dbo].[TipoProducto]
        ([IdTipoProcuto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProductoProducto'
CREATE INDEX [IX_FK_TipoProductoProducto]
ON [dbo].[Producto]
    ([TipoProducto_IdTipoProcuto]);
GO

-- Creating foreign key on [EntradasProducto_Producto_IdInventario] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_EntradasProducto]
    FOREIGN KEY ([EntradasProducto_Producto_IdInventario])
    REFERENCES [dbo].[Inventario]
        ([IdInventario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntradasProducto'
CREATE INDEX [IX_FK_EntradasProducto]
ON [dbo].[Producto]
    ([EntradasProducto_Producto_IdInventario]);
GO

-- Creating foreign key on [Producto_IdProducto] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [FK_ProductoDetalleVentas]
    FOREIGN KEY ([Producto_IdProducto])
    REFERENCES [dbo].[Producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleVentas'
CREATE INDEX [IX_FK_ProductoDetalleVentas]
ON [dbo].[DetalleFacturas]
    ([Producto_IdProducto]);
GO

-- Creating foreign key on [Precio_IdPrecio] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [FK_PrecioDetalleVentas]
    FOREIGN KEY ([Precio_IdPrecio])
    REFERENCES [dbo].[Precio]
        ([IdPrecio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrecioDetalleVentas'
CREATE INDEX [IX_FK_PrecioDetalleVentas]
ON [dbo].[DetalleFacturas]
    ([Precio_IdPrecio]);
GO

-- Creating foreign key on [Facturas_IdFacturas] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [FK_VentasDetalleVentas]
    FOREIGN KEY ([Facturas_IdFacturas])
    REFERENCES [dbo].[Facturas]
        ([IdFacturas])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasDetalleVentas'
CREATE INDEX [IX_FK_VentasDetalleVentas]
ON [dbo].[DetalleFacturas]
    ([Facturas_IdFacturas]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------