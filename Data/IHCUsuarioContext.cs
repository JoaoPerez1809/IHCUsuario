using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IHCUsuario.Models;

namespace IHCUsuario.Data
{
    public class IHCUsuarioContext : DbContext
    {
        public IHCUsuarioContext (DbContextOptions<IHCUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<IHCUsuario.Models.Cliente> Cliente { get; set; } = default!;
    }
}
