using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SistemaVentasVB.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Categorias m_Categorias;

            public Categorias Categorias
            {
                [DebuggerHidden]
                get
                {
                    m_Categorias = Create__Instance__(m_Categorias);
                    return m_Categorias;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Categorias))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Categorias);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Clientes m_Clientes;

            public Clientes Clientes
            {
                [DebuggerHidden]
                get
                {
                    m_Clientes = Create__Instance__(m_Clientes);
                    return m_Clientes;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Clientes))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Clientes);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Compras m_Compras;

            public Compras Compras
            {
                [DebuggerHidden]
                get
                {
                    m_Compras = Create__Instance__(m_Compras);
                    return m_Compras;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Compras))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Compras);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public DetalleCompra m_DetalleCompra;

            public DetalleCompra DetalleCompra
            {
                [DebuggerHidden]
                get
                {
                    m_DetalleCompra = Create__Instance__(m_DetalleCompra);
                    return m_DetalleCompra;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DetalleCompra))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DetalleCompra);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public DetalleVenta m_DetalleVenta;

            public DetalleVenta DetalleVenta
            {
                [DebuggerHidden]
                get
                {
                    m_DetalleVenta = Create__Instance__(m_DetalleVenta);
                    return m_DetalleVenta;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DetalleVenta))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DetalleVenta);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Inicio m_Inicio;

            public Inicio Inicio
            {
                [DebuggerHidden]
                get
                {
                    m_Inicio = Create__Instance__(m_Inicio);
                    return m_Inicio;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Inicio))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Inicio);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Login))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Login);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Marcas m_Marcas;

            public Marcas Marcas
            {
                [DebuggerHidden]
                get
                {
                    m_Marcas = Create__Instance__(m_Marcas);
                    return m_Marcas;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Marcas))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Marcas);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Productos m_Productos;

            public Productos Productos
            {
                [DebuggerHidden]
                get
                {
                    m_Productos = Create__Instance__(m_Productos);
                    return m_Productos;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Productos))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Productos);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Proveedores m_Proveedores;

            public Proveedores Proveedores
            {
                [DebuggerHidden]
                get
                {
                    m_Proveedores = Create__Instance__(m_Proveedores);
                    return m_Proveedores;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Proveedores))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Proveedores);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Usuarios m_Usuarios;

            public Usuarios Usuarios
            {
                [DebuggerHidden]
                get
                {
                    m_Usuarios = Create__Instance__(m_Usuarios);
                    return m_Usuarios;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Usuarios))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Usuarios);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Ventas m_Ventas;

            public Ventas Ventas
            {
                [DebuggerHidden]
                get
                {
                    m_Ventas = Create__Instance__(m_Ventas);
                    return m_Ventas;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Ventas))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Ventas);
                }
            }

        }


    }
}