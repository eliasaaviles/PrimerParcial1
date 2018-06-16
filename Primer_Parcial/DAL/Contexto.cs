using System;
using Primer_Parcial.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;

namespace Primer_Parcial.DAL
{
    class Contexto : DbContext
    {
        public DbSet<GrupoEstudiantes> grupoEstudiantes { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
