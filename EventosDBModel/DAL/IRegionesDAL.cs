using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDBModel.DAL
{
    public interface IRegionesDAL
    {
        List<Region> ObtenerRegiones();
    }
}
