﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intertazz.Data
{
    public class Bussiness
    {
        #region CRUD PRODUCTO
        public Producto CrearProducto(Producto Producto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Producto.Add(Producto);
                context.SaveChanges();
            }
            return Producto;
        }
        public Producto ActualizarProducto(Producto Producto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Producto ProductoModificar = context.Producto.Where(x => x.IdProducto == Producto.IdProducto).FirstOrDefault();
                ProductoModificar.Marca = Producto.Marca;
                ProductoModificar.Nombre = Producto.Nombre;
                ProductoModificar.Referencia = Producto.Referencia;
                ProductoModificar.TipoProducto = Producto.TipoProducto;
                ProductoModificar.Categoria = Producto.Categoria;
                context.SaveChanges();
                return ProductoModificar;
            }
        }
        public Producto EliminarProducto(Producto Producto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Producto ProductoModificar = context.Producto.Where(x => x.IdProducto == Producto.IdProducto).FirstOrDefault();
                ProductoModificar.Activo = false;
                context.SaveChanges();
                return ProductoModificar;
            }

        }

        public List<Producto> ObtenerProducto(Producto Producto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Producto.Where(x => x.IdProducto == Producto.IdProducto).ToList();
            }

        }
        #endregion


        #region CRUD Marca          
        public Marca CrearMarca(Marca Marca)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Marca.Add(Marca); context.SaveChanges();
            }
            return Marca;
        }
        public Marca ActualizarMarca(Marca Marca)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Marca MarcaModificar = context.Marca.Where(x => x.IdMarca == Marca.IdMarca).FirstOrDefault();
                MarcaModificar.Producto = Marca.Producto;
                MarcaModificar.Nombre = Marca.Nombre;
                context.SaveChanges(); return MarcaModificar;
            }
        }
        public Marca EliminarMarca(Marca Marca)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Marca MarcaModificar = context.Marca.Where(x => x.IdMarca == Marca.IdMarca).FirstOrDefault();
                MarcaModificar.Activo = false;
                context.SaveChanges();
                return MarcaModificar;
            }
        }
        public List<Marca> ObtenerMarca(Marca Marca)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Marca.Where(x => x.IdMarca == Marca.IdMarca).ToList();
            }
        }
        #endregion
        #region CRUD Facturas          
        public Facturas CrearFacturas(Facturas Facturas)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Facturas.Add(Facturas); context.SaveChanges();
            }
            return Facturas;
        }
        public Facturas ActualizarFacturas(Facturas Facturas)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Facturas FacturasModificar = context.Facturas.Where(x => x.IdFacturas == Facturas.IdFacturas).FirstOrDefault();
                FacturasModificar.Descuento = Facturas.Descuento;
                FacturasModificar.Fecha = Facturas.Fecha;
                FacturasModificar.ValorTotal = Facturas.ValorTotal;
                context.SaveChanges();
                return FacturasModificar;
            }
        }
        public Facturas EliminarFacturas(Facturas Facturas)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Facturas FacturasModificar = context.Facturas.Where(x => x.IdFacturas == Facturas.IdFacturas).FirstOrDefault();
                FacturasModificar.Activo = false; context.SaveChanges(); return FacturasModificar;
            }
        }
        public List<Facturas> ObtenerFacturas(Facturas Facturas)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Facturas.Where(x => x.IdFacturas == Facturas.IdFacturas).ToList();
            }
        }
        #endregion
        #region CRUD Stock          
        public Stock CrearStock(Stock Stock)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Stock.Add(Stock); context.SaveChanges();
            }
            return Stock;
        }
        public Stock ActualizarStock(Stock Stock)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Stock StockModificar = context.Stock.Where(x => x.IdInventario == Stock.IdInventario).FirstOrDefault();
                StockModificar.Cantidad = Stock.Cantidad;
                StockModificar.Producto = Stock.Producto;
                context.SaveChanges();
                return StockModificar;
            }
        }
        public Stock EliminarStock(Stock Stock)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Stock StockModificar = context.Stock.Where(x => x.IdInventario == Stock.IdInventario).FirstOrDefault();
                StockModificar.Activo = false; context.SaveChanges(); return StockModificar;
            }
        }
        public List<Stock> ObtenerStock(Stock Stock)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            { return context.Stock.Where(x => x.IdInventario == Stock.IdInventario).ToList(); }
        }
        #endregion
        #region CRUD Precio          
        public Precio CrearPrecio(Precio Precio)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Precio.Add(Precio); context.SaveChanges();
            }
            return Precio;
        }
        public Precio ActualizarPrecio(Precio Precio)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Precio PrecioModificar = context.Precio.Where(x => x.IdPrecio == Precio.IdPrecio).FirstOrDefault();
                PrecioModificar.DetalleVentas = Precio.DetalleVentas;
                PrecioModificar.Fecha = Precio.Fecha;
                PrecioModificar.Producto = Precio.Producto;
                context.SaveChanges(); return PrecioModificar;
            }
        }
        public Precio EliminarPrecio(Precio Precio)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Precio PrecioModificar = context.Precio.Where(x => x.IdPrecio == Precio.IdPrecio).FirstOrDefault();
                PrecioModificar.Activo = false;
                context.SaveChanges();
                return PrecioModificar;
            }
        }
        public List<Precio> ObtenerPrecio(Precio Precio)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Precio.Where(x => x.IdPrecio == Precio.IdPrecio).ToList();
            }
        }
        #endregion
        #region CRUD TipoProducto          
        public TipoProducto CrearTipoProducto(TipoProducto TipoProducto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.TipoProducto.Add(TipoProducto);
                context.SaveChanges();
            }
            return TipoProducto;
        }
        public TipoProducto ActualizarTipoProducto(TipoProducto TipoProducto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                TipoProducto TipoProductoModificar = context.TipoProducto.Where(
                    x => x.IdTipoProcuto == TipoProducto.IdTipoProcuto).FirstOrDefault();
                TipoProductoModificar.Nombre = TipoProducto.Nombre;
                context.SaveChanges();
                return TipoProductoModificar;
            }
        }
        public TipoProducto EliminarTipoProducto(TipoProducto TipoProducto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                TipoProducto TipoProductoModificar = context.TipoProducto.Where(
                  x => x.IdTipoProcuto == TipoProducto.IdTipoProcuto).FirstOrDefault();
                TipoProductoModificar.Activo = false;
                context.SaveChanges(); return TipoProductoModificar;
            }
        }
        public List<TipoProducto> ObtenerTipoProducto(TipoProducto TipoProducto)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.TipoProducto.Where(x => x.IdTipoProcuto == TipoProducto.IdTipoProcuto).ToList();
            }
        }
        #endregion
        #region CRUD Categoria          
        public Categoria CrearCategoria(Categoria Categoria)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Categoria.Add(Categoria);
                context.SaveChanges();
            }
            return Categoria;
        }
        public Categoria ActualizarCategoria(Categoria Categoria)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                Categoria CategoriaModificar = context.Categoria.Where(x => x.IdCategoria == Categoria.IdCategoria).FirstOrDefault();
                CategoriaModificar.Caja = Categoria.Caja;
                CategoriaModificar.Nombre = Categoria.Nombre;
                context.SaveChanges();
                return CategoriaModificar;
            }
        }
        public Categoria EliminarCategoria(Categoria Categoria)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            { Categoria CategoriaModificar = context.Categoria.Where(x => x.IdCategoria == Categoria.IdCategoria).FirstOrDefault(); 
                CategoriaModificar.Activo = false; context.SaveChanges(); return CategoriaModificar; 
            }
        }
        public List<Categoria> ObtenerCategoria(Categoria Categoria)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Categoria.Where(x => x.IdCategoria == Categoria.IdCategoria).ToList();
            }
        }
        #endregion

        #region CRUD Inventario          
        public Inventario CrearInventario(Inventario Inventario)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                context.Inventario.Add(Inventario); context.SaveChanges();
            }
            return Inventario;
        }
        public Inventario ActualizarInventario(Inventario Inventario)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            { Inventario InventarioModificar = context.Inventario.Where(x => x.IdInventario == Inventario.IdInventario).FirstOrDefault(); 
                InventarioModificar.Cantidad = Inventario.Cantidad; 
                InventarioModificar.Fecha = Inventario.Fecha; 
                InventarioModificar.Producto = Inventario.Producto; 
                context.SaveChanges(); 
                return InventarioModificar; 
            }
        }
        public Inventario EliminarInventario(Inventario Inventario)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            { Inventario InventarioModificar = context.Inventario.Where(x => x.IdInventario == Inventario.IdInventario).FirstOrDefault(); InventarioModificar.Activo = false; context.SaveChanges(); return InventarioModificar; }
        }
        public List<Inventario> ObtenerInventario(Inventario Inventario)
        {
            using (EFIntertazzModelContainer context = new EFIntertazzModelContainer())
            {
                return context.Inventario.Where(x => x.IdInventario == Inventario.IdInventario).ToList();
            }
        }
        #endregion
    }
}
