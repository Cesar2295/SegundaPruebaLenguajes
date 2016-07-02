using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notificador.Model;

namespace Notificador.AccesoAdatos
{
   public class GestorDeConfiguracionDeNotificacion
    {
        public bool AgregarNotificacion(ConfiguracionDeNotificacion laConfiguracion)
        {
            var db = new Context();

            db.ConfiguracionDeNotificacion.Add(laConfiguracion);
            db.Entry(laConfiguracion).State = System.Data.Entity.EntityState.Added;

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
        public bool EditarNotificacion(ConfiguracionDeNotificacion laConfiguracion)
        {
            var db = new Context();

            db.Entry(laConfiguracion).State = System.Data.Entity.EntityState.Modified;

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
        public List<ConfiguracionDeNotificacion> ListarConfiguraciones()
        {
            var db = new Context();

            var resultado = db.ConfiguracionDeNotificacion.ToList();

            return resultado;
        }
    }
}
