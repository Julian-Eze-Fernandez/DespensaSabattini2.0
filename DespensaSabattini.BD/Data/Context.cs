using DespensaSabattini.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespensaSabattini.BD.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Rol> Roles => Set<Rol>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Pago> Pagos => Set<Pago>();
        public DbSet<TipoPago> TipoPagos => Set<TipoPago>();
        public DbSet<Proveedor> Proveedores => Set<Proveedor>();
    }
}
