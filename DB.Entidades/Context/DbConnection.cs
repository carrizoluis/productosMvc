using DB.Entidades.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Entidades.Context
{
    public class DbConnection : DbContext
    {
        private IConfiguration Configuration;
        public virtual DbSet<Producto> Producto { get; set; }

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
