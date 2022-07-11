using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDBModel.DAL
{
    public class RegionesDALDB : IRegionesDAL
    {
        private EventosDBEntities eventosDB = new EventosDBEntities();
        public List<Region> ObtenerRegiones()
        {
            return this.eventosDB.Regions.ToList();
        }
    }
}
