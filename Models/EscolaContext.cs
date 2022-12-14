using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudMvcEscola.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("Escola")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Aluno> Alunos { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .Property(a => a.Id);
        }*/
    }
}