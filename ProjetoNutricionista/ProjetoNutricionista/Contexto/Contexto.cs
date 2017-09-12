using ProjetoNutricionista.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNutricionista.Contexto
{
    class Contexto:DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Nutricionista> Nutricionista { get; set; }
        public DbSet<Imc> Imc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove a pluralização no nome das tabelas.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
