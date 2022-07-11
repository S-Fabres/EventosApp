using EventosDBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDBModel.DAL
{
     public class AsistentesDALDB : IAsistentesDAL
    {
        private EventosDBEntities eventosDB = new EventosDBEntities();
        public void AgregarAsistente(Asistente asistente)
        {
            this.eventosDB.Asistentes.Add(asistente);
            this.eventosDB.SaveChanges();
        }

        public void EliminarAsistente(int id)
        {
            Asistente asistente = this.eventosDB.Asistentes.Find(id);
            this.eventosDB.Asistentes.Remove(asistente);
            this.eventosDB.SaveChanges();
        }

        public Asistente Obtener(int id)
        {
            return this.eventosDB.Asistentes.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.eventosDB.Asistentes.ToList();
        }

        public void Actualizar(Asistente a)
        {
            Asistente asistenteOrig = this.eventosDB.Asistentes.Find(a.Id);
            asistenteOrig.Estado = a.Estado;
            asistenteOrig.Nombre = a.Nombre;
            asistenteOrig.Apellido = a.Apellido;
            this.eventosDB.SaveChanges();
        }

        public List<Asistente> ObtenerAsistentes(string estado)
        {
            throw new NotImplementedException();
        }

        /**public List<Asistente> ObtenerAsistentes(string estado)
        {
            throw new NotImplementedException();
        }**/
    }
}
