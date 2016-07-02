using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notificador.Model;

namespace Notificador.AccesoAdatos
{
    public class GestorDePersonas
    {
        public bool AgregarPersona(Persona laPersona)
        {
            var db = new Context();

            db.Persona.Add(laPersona);
            db.Entry(laPersona).State = System.Data.Entity.EntityState.Added;

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarPersona(Persona laPersona)
        {
            var db = new Context();

            db.Entry(laPersona).State = System.Data.Entity.EntityState.Modified;

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Persona> ListarPersonas()
        {
            var db = new Context();

            var resultado = db.Persona.ToList();

            return resultado;
        }
    }
}
