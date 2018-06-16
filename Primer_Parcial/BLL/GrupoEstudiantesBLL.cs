using System;
using Primer_Parcial.Entidades;
using Primer_Parcial.DAL;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Primer_Parcial.BLL
{
    public class GrupoEstudiantesBLL
    {

        public static bool Guardar(GrupoEstudiantes estudiantes)

        {

            bool guardado = false;

            Contexto contexto = new Contexto();

            contexto.grupoEstudiantes.Add(estudiantes);

            contexto.SaveChanges();

            guardado = true;


            contexto.Dispose();

            return guardado;

        }
        public static GrupoEstudiantes Buscar(int grupoid)
        {
            Contexto contexto = new Contexto();
            GrupoEstudiantes estudiantes = new GrupoEstudiantes();

            estudiantes = contexto.grupoEstudiantes.Find(grupoid);
            return estudiantes;
        }
        public static bool Eliminar(int GrupoID)

        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            GrupoEstudiantes grupo = contexto.grupoEstudiantes.Find(GrupoID);
            contexto.grupoEstudiantes.Remove(grupo);
            if (contexto.SaveChanges() > 0)
            {
                eliminado = true;
            }

            return eliminado;

        }
        public static bool Modificar(GrupoEstudiantes estudiantes)
        {
            bool modificado = false;
            Contexto contexto = new Contexto();



            contexto.Entry(estudiantes).State = EntityState.Modified;
            if (contexto.SaveChanges() > 0)
            {
                modificado = true;
            }
            contexto.Dispose();

            return modificado;
        }

        public static List<GrupoEstudiantes> GetList(Expression<Func<GrupoEstudiantes, bool>> expression)
        {
            List<GrupoEstudiantes> estudiantes = new List<GrupoEstudiantes>();
            Contexto contexto = new Contexto();

            estudiantes = contexto.grupoEstudiantes.Where(expression).ToList();
            contexto.Dispose();
            return estudiantes;
        }
    }

    }
