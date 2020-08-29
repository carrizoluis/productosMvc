using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using productosMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productosMvc.Context
{
    public class DbConnection : DbContext
    {
        private IConfiguration Configuration;
        public virtual DbSet<Producto> Productos { get; set; }

        public DbConnection(IConfiguration configuration) 
        {
            this.Configuration = configuration;
        }

        //Sobreescribimos el metodo OnConfiguring para hacer los ajustes que queramos en caso de
        //llamar al constructor sin parametros
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(Configuration["StringConnection"]);

            }
        }
    }
}
