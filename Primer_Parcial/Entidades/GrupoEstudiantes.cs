using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Primer_Parcial.Entidades
{
    public class GrupoEstudiantes
    {

        [Key]
        public int GrupoID { get; set; }
        public String Descripcion { get; set; }
        public int Cantidad { get; set; }

        public int Grupos { get; set; }

        public int Integrantes { get; set; }

        public String Fecha { get; set; }

    }


    }

